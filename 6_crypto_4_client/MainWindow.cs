using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Unicode;

namespace _6_crypto_4_client
{
	public partial class MainWindow : Form
	{
		private IClient? client;

		private IPAddress? host;
		private int port;

		private TcpClient? tcpClient;
		private NetworkStream? stream;

		public MainWindow()
		{
			InitializeComponent();

			tcpClient = null;

			LogOut();

			textBoxSignUpAdminCode.Visible = false;

			comboBoxChooseRole.SelectedIndex = 0;
			comboBoxChooseRole.SelectedIndexChanged += ComboBoxChooseRole_SelectedIndexChanged;

			buttonSignUp.Click += ButtonSignUp_Click;
			buttonSignIn.Click += ButtonSignIn_Click;
			buttonLogOut.Click += ButtonLogOut_Click;
			
			buttonCatalogAddMoneyToBalance.Click += ButtonCatalogAddMoneyToBalance_Click;
			buttonCatalogRefresh.Click += ButtonCatalogRefresh_Click;
			buttonCatalogBuy.Click += ButtonCatalogBuy_Click;

			buttonYourProductsRefresh.Click += ButtonYourProductsRefresh_Click;
			buttonYourProductsRemoveProduct.Click += ButtonYourProductsRemoveProduct_Click;

			buttonAddProduct.Click += ButtonAddProduct_Click;

			buttonOnlineClientsRefresh.Click += ButtonOnlineClientsRefresh_Click;
		}

		private void ButtonSignUp_Click(object? sender, EventArgs e)
		{
			string message, response, name, password, repeatPassword, role, code;
			byte[] messageBytes;
			byte[] responseBytes = new byte[3];
			int bytesRead;

			if (tcpClient == null)
			{
				try
				{
					TryToConnectToTheServer();
				}
				catch
				{
					MessageBox.Show("�� ������� ������������ � �������. ��������� ������������ ����� ����� � �����, ���� ��� ������� ����� �������� ������ ������ ��������.");
					tcpClient = null;
					return;
				}
			}

			name = textBoxSignUpName.Text;
			password = textBoxSignUpPassword.Text;
			repeatPassword = textBoxSignUpRepeatPassword.Text;

			role = comboBoxChooseRole.SelectedIndex.ToString();

			message = $"sup-{name}-{password}-{repeatPassword}-{role}";

			if (role == "2")
			{
				code = textBoxSignUpAdminCode.Text;
				message += $"-{code}";
			}

			messageBytes = Encoding.UTF8.GetBytes(message);
			stream.Write(messageBytes, 0, messageBytes.Length);

			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			if (response == "yes")
			{
				MessageBox.Show("����������� ������ �������, ������ �� ������ ����� � ������� ��� ����� ����������� � �������.");
			}
			else if (response == "exs")
			{
				MessageBox.Show("�� ������� ������������������. ������������ � ����� ����������� ��� ����������.");
				textBoxSignUpName.Text = "";
			}
			else if (response == "bnm")
			{
				MessageBox.Show("�� ������� ������������������. ��������� �������� ������������ �������.");
				textBoxSignUpName.Text = "";
			}
			else if (response == "bpw")
			{
				MessageBox.Show("�� ������� ������������������. ������ �������� ������������ �������.");
				textBoxSignUpPassword.Text = "";
				textBoxSignUpRepeatPassword.Text = "";
			}
			else if (response == "lnm")
			{
				MessageBox.Show("�� ������� ������������������. ��������� ������� �� ������� ���������� �����.");
				textBoxSignUpName.Text = "";
			}
			else if (response == "lpw")
			{
				MessageBox.Show("�� ������� ������������������. ������ ������� �� ������� ���������� �����.");
				textBoxSignUpPassword.Text = "";
				textBoxSignUpRepeatPassword.Text = "";
			}
			else if (response == "dpw")
			{
				MessageBox.Show("�� ������� ������������������. ������ �� ���������.");
				textBoxSignUpPassword.Text = "";
				textBoxSignUpRepeatPassword.Text = "";
			}
			else if (response == "wrr")
			{
				MessageBox.Show("�� ������� ������������������. ������� ������������ ����.");
				comboBoxChooseRole.SelectedIndex = 0;
			}
			else if (response == "wrc")
			{
				MessageBox.Show("�� ������� ������������������. ��� �������������� ��������.");
				textBoxSignUpAdminCode.Text = "";
			}
			else if (response == "nea")
			{
				MessageBox.Show("�� ������� ������������������. �������� ������������ ��������.");
			}
			else
			{
				MessageBox.Show($"���-�� ����� �� ���! response = |{response}|");
			}
		}

		private void ButtonSignIn_Click(object? sender, EventArgs e)
		{
			string message, response, name, password;
			byte[] messageBytes, responseBytes = new byte[16];
			int bytesRead;

			if (tcpClient == null)
			{
				try
				{
					TryToConnectToTheServer();
				}
				catch
				{
					MessageBox.Show("�� ������� ������������ � �������. ��������� ������������ ����� ����� � �����, ���� ��� ������� ����� �������� ������ ������ ��������.");

					return;
				}
			}

			name = textBoxSignInName.Text;
			password = textBoxSignInPassword.Text;

			message = $"sin-{name}-{password}";

			messageBytes = Encoding.UTF8.GetBytes(message);
			stream.Write(messageBytes, 0, messageBytes.Length);

			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			if (response.Substring(0, 3) == "buy")
			{
				decimal balance;

				try
				{
					balance = decimal.Parse(response.Substring(4));
				}
				catch
				{
					MessageBox.Show("�� ������� �����. ������ �� �������� ������.");
					tcpClient = null;
					return;
				}

				client = new Buyer(name, password, balance);

				tabPageSignUp.Parent = null;
				tabPageSignIn.Parent = null;

				tableLayoutPanelLogIn.Visible = true;
				labelWelcomeMesage.Text = $"����� ����������, {name}";

				tabPageCatalog.Parent = tabControlMain;
				labelCatalogBalanceValue.Text = (balance).ToString();

				DoBuyerCommands();
			}
			else if (response == "sel")
			{
				client = new Seller(name, password);

				tabPageSignUp.Parent = null;
				tabPageSignIn.Parent = null;

				tableLayoutPanelLogIn.Visible = true;
				labelWelcomeMesage.Text = $"����� ����������, {name}";

				tabPageYourProducts.Parent = tabControlMain;
				tabPageAddProduct.Parent = tabControlMain;

				DoSellerCommands();
			}
			else if (response == "adm")
			{
				client = new Administrator(name, password);

				tabPageSignUp.Parent = null;
				tabPageSignIn.Parent = null;

				tableLayoutPanelLogIn.Visible = true;
				labelWelcomeMesage.Text = $"����� ����������, {name}";

				tabPageCatalog.Parent = tabControlMain;
				tabPageOnlineClients.Parent = tabControlMain;

				labelCatalogBalanceValue.Text = "-1";

				DoAdministratorCommands();
			}
			else if (response == "unn")
			{
				MessageBox.Show("�� ������� �����. ������������ � ����� ������ �� ����������.");
				textBoxSignInName.Text = "";
				return;
			}
			else if (response == "bnm")
			{
				MessageBox.Show("�� ������� �����. ��������� �������� ������������ �������.");
				textBoxSignInName.Text = "";
			}
			else if (response == "bpw")
			{
				MessageBox.Show("�� ������� �����. ������ �������� ������������ �������.");
				textBoxSignInPassword.Text = "";
			}
			else if (response == "lnm")
			{
				MessageBox.Show("�� ������� �����. ��������� ������� �� ������� ���������� �����.");
				textBoxSignInName.Text = "";
			}
			else if (response == "lpw")
			{
				MessageBox.Show("�� ������� �����. ������ ������� �� ������� ���������� �����.");
				textBoxSignInPassword.Text = "";
			}
			else if (response == "wrp")
			{
				MessageBox.Show("�� ������� �����. ������ ��������.");
				textBoxSignInPassword.Text = "";
				return;
			}
			else if (response == "nea")
			{
				MessageBox.Show("�� ������� �����. �������� ������������ ��������.");
			}
			else if (response == "cao")
			{
				textBoxSignInName.Text = "";
				textBoxSignInPassword.Text = "";
				MessageBox.Show("�� ������� �����. ������������ � ����� ������ ��� ��������� ������.");
			}
			else
			{
				MessageBox.Show($"���-�� ����� �� ���! response = |{response}|");
			}
		}

		private void ButtonCatalogRefresh_Click(object? sender, EventArgs e)
		{
			GetProducts("gap");
		}

		private void ButtonCatalogBuy_Click(object? sender, EventArgs e)
		{
			if (listBoxCatalog.SelectedItem == null)
			{
				MessageBox.Show("�� �� ������� ����� ��� �������");

				return;
			}

			string product;
			string message, response;
			byte[] messageBytes, responseBytes;
			int bytesRead;

			if (client is IBuyer buyer)
			{
				responseBytes = new byte[3];

				product = listBoxCatalog.SelectedItem.ToString();
				product = product.Replace(" - ", "-");
				product = product.Replace(" (", "-");
				product = product.Replace(")", "");

				message = $"bpr-{client.Name}-{client.Password}-{product}";
				messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);
				stream.Write(messageBytes, 0, messageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);
				if (response != "yes")
				{
					MessageBox.Show("�� �� ������ ������ �����");
					return;
				}

				message = "nxt";
				messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);
				stream.Write(messageBytes, 0, messageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);
				if (response == "yes")
				{
					MessageBox.Show("�� ������� ������ �����");
					GetProducts("gap");
					labelCatalogBalanceValue.Text = GetBalance();
				}
				else if (response == "nem")
				{
					MessageBox.Show("� ��� ������������ ������� �� �������");
				}
			}
			else
			{
				MessageBox.Show("�� �� ����������");
				return;
			}
		}

		private void ButtonCatalogAddMoneyToBalance_Click(object? sender, EventArgs e)
		{
			string message, response;
			byte[] messageBytes, responseBytes = new byte[50];
			int bytesRead;
			decimal newBalance;

			if (client is IBuyer buyer)
			{
				message = $"amb-{client.Name}-{client.Password}";
				messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);
				stream.Write(messageBytes, 0, messageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

				if (response == "adm")
				{
					MessageBox.Show("��, ��� �������������, ��������� ������������ ��������");
					return;
				}
				else if (response == "tmm")
				{
					MessageBox.Show("� ��� � ��� ������� ����� ����� (����� ��������), ��������� ��������� ���������� ����� ��������� ������");
					return;
				}
				else
				{
					try
					{
						newBalance = Convert.ToDecimal(response);
						buyer.Balance = newBalance;

						labelCatalogBalanceValue.Text = response;
					}
					catch
					{
						MessageBox.Show("�� ������� ��������� ������");
					}
				}
			}
			else
			{
				MessageBox.Show("�� �� ����������.");
				LogOut();
				return;
			}
		}

		private string GetBalance()
		{
			string message = $"gbl-{client.Name}-{client.Password}", response;
			byte[] messageBytes, responseBytes = new byte[50];
			int bytesRead;

			messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);
			stream.Write(messageBytes, 0, messageBytes.Length);

			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			return response;
		}

		private void DoBuyerCommands()
		{
			if (client is IBuyer buyer)
			{
				GetProducts("gap");
			}
			else
			{
				MessageBox.Show("�� �� ����������");
				return;
			}
		}

		private void DoSellerCommands()
		{
			if (client is ISeller seller)
			{
				GetProducts("gyp");
			}
			else
			{
				MessageBox.Show("�� �� ��������");
				return;
			}
		}

		private void DoAdministratorCommands()
		{
			if (client is IAdministrator admin)
			{
				GetProducts("gap");
				GetOnlineClients();
			}
			else
			{
				MessageBox.Show("�� �� �������������.");
				return;
			}
		}

		private void GetOnlineClients()
		{
			string[] onlineClients, splitOnlineClient;
			string message = $"goc-{client.Name}-{client.Password}",
				nextMessage = "nxt",
				response;
			byte[] messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length),
				nextMessageBytes = Encoding.UTF8.GetBytes(nextMessage, 0, nextMessage.Length),
				responseBytes;
			int bytesRead;
			long numberOfOnlineClients;

			stream.Write(messageBytes, 0, messageBytes.Length);

			responseBytes = new byte[3];
			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);
			if (response != "yes")
			{
				MessageBox.Show("�� �� ������ �������� ������ � ������ � ��������, ����������� ������");
				return;
			}

			stream.Write(nextMessageBytes, 0, nextMessageBytes.Length);
			
			responseBytes = new byte[12];
			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			try
			{
				numberOfOnlineClients = Convert.ToInt64(response);
			}
			catch
			{
				MessageBox.Show("���������� �������� ������ - �� �����");
				return;
			}

			responseBytes = new byte[20 + 20 + 1];
			onlineClients = new string[numberOfOnlineClients];

			for (int i = 0; i < numberOfOnlineClients; i++)
			{
				stream.Write(nextMessageBytes, 0, nextMessageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

				splitOnlineClient = response.Split('-');
				onlineClients[i] = $"������������ - {splitOnlineClient[0]}, ������: {splitOnlineClient[1]}";
			}

			listBoxOnlineClients.Items.Clear();
			listBoxOnlineClients.Items.AddRange(onlineClients);
		}

		private void ButtonOnlineClientsRefresh_Click(object? sender, EventArgs e)
		{
			GetOnlineClients();
		}

		private void ButtonYourProductsRefresh_Click(object? sender, EventArgs e)
		{
			GetProducts("gyp");
		}

		private void ButtonYourProductsRemoveProduct_Click(object? sender, EventArgs e)
		{
			if (listBoxYourProducts.SelectedItem == null)
			{
				MessageBox.Show("�� �� ������� ����� ��� ��������");

				return;
			}

			string product;
			string message, response;
			byte[] messageBytes, responseBytes;
			int bytesRead;

			if (client is ISeller seller)
			{
				responseBytes = new byte[3];

				product = listBoxYourProducts.SelectedItem.ToString();
				product = product.Replace(" - ", "-");
				product = product.Replace(" (", "-");
				product = product.Replace(")", "");

				message = $"rpr-{client.Name}-{client.Password}-{product}";
				messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);
				stream.Write(messageBytes, 0, messageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);
				if (response != "yes")
				{
					MessageBox.Show("�� �� ������ ������� �����");
					return;
				}

				GetProducts("gyp");
			}
			else
			{
				MessageBox.Show("�� �� ����������");
				return;
			}
		}

		private void ButtonAddProduct_Click(object? sender, EventArgs e)
		{
			string message, response;
			byte[] messageBytes, responseBytes = new byte[3];
			int bytesRead;

			message = $"apr-{client.Name}-{client.Password}-{textBoxAddProductName.Text}-{textBoxAddProductCost.Text}";

			messageBytes = Encoding.UTF8.GetBytes(message);
			stream.Write(messageBytes, 0, messageBytes.Length);

			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			if (response == "yes")
			{
				MessageBox.Show("����� ������� �������� � �������.");
				textBoxAddProductName.Text = "";
				textBoxAddProductCost.Text = "";
				GetProducts("gyp");
			}
			else if (response == "unn")
			{
				MessageBox.Show("�� ������� �������� �����. ������������ � ����� ������ �� ����������.");
				textBoxAddProductName.Text = "";
			}
			else if (response == "tmp")
			{
				MessageBox.Show("�� ������� �������� �����. �� ����� ��� ������� ����� �������.");
				textBoxAddProductName.Text = "";
				textBoxAddProductCost.Text = "";
			}
			else if (response == "bpn")
			{
				MessageBox.Show("�� ������� �������� �����. �������� ������ �������� ������������ �������.");
				textBoxAddProductName.Text = "";
			}
			else if (response == "lpr")
			{
				MessageBox.Show("�� ������� �������� �����. �������� ������ ������� �� ������� ���������� �����.");
				textBoxSignInName.Text = "";
			}
			else if (response == "bln")
			{
				MessageBox.Show("�� ������� �������� �����. ����� ���� ������ �� ������ ��������� 50 � �� ������ ���� ������ 1.");
				textBoxAddProductCost.Text = "";
			}
			else if (response == "nan")
			{
				MessageBox.Show("�� ������� �������� �����. ���� ������ �� �������� ������.");
				textBoxAddProductCost.Text = "";
			}
			else if (response == "bnu")
			{
				MessageBox.Show("�� ������� �������� �����. ���� ������ ������� �� ������� ����������� ���������.");
				textBoxAddProductCost.Text = "";
			}
			else if (response == "nea")
			{
				MessageBox.Show("�� ������� �������� �����. ������������ ���������� ����������.");
				textBoxAddProductCost.Text = "";
			}
			else
			{
				MessageBox.Show($"���-�� ����� �� ���! response = |{response}|");
			}
		}

		private void TryToConnectToTheServer()
		{
			host = IPAddress.Parse(textBoxEnterHost.Text);
			port = Convert.ToInt32(textBoxEnterPort.Text);

			tcpClient = new TcpClient();
			tcpClient.Connect(host, port);

			stream = tcpClient.GetStream();
		}

		private void GetProducts(string code)
		{
			string[] products, splitProduct;
			string message = $"{code}-{client.Name}-{client.Password}",
				nextMessage = "nxt",
				response;
			byte[] messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length),
				nextMessageBytes = Encoding.UTF8.GetBytes(nextMessage, 0, nextMessage.Length),
				responseBytes;
			int bytesRead;
			long numberOfProducts = 0;

			stream.Write(messageBytes, 0, messageBytes.Length);
			responseBytes = new byte[3];
			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);
			if (response != "yes")
			{
				MessageBox.Show("�� �� ������ �������� ������ � �������");
				return;
			}

			stream.Write(nextMessageBytes, 0, nextMessageBytes.Length);
			responseBytes = new byte[12];

			bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
			response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

			try
			{
				numberOfProducts = Convert.ToInt64(response);
			}
			catch
			{
				MessageBox.Show("���������� ��������� - �� �����");
				return;
			}

			responseBytes = new byte[20 + 50 + 50 + 2];
			products = new string[numberOfProducts];

			for (int i = 0; i < numberOfProducts; i++)
			{
				stream.Write(nextMessageBytes, 0, nextMessageBytes.Length);

				bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
				response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

				splitProduct = response.Split('-');
				products[i] = $"{splitProduct[1]} - {splitProduct[2]} ({splitProduct[0]})";
			}

			if (code == "gap")
			{
				listBoxCatalog.Items.Clear();
				listBoxCatalog.Items.AddRange(products);
			}
			else if (code == "gyp")
			{
				listBoxYourProducts.Items.Clear();
				listBoxYourProducts.Items.AddRange(products);
			}
		}

		private void ComboBoxChooseRole_SelectedIndexChanged(object? sender, EventArgs e)
		{
			if (comboBoxChooseRole.SelectedIndex == 2)
				textBoxSignUpAdminCode.Visible = true;
			else
			{
				textBoxSignUpAdminCode.Text = "";
				textBoxSignUpAdminCode.Visible = false;
			}
		}

		private void ButtonLogOut_Click(object? sender, EventArgs e)
		{
			LogOut();
		}

		private void LogOut()
		{
			string message;
			byte[] messageBytes;

			if (client != null)
			{
				message = $"out-{client.Name}-{client.Password}";
				messageBytes = Encoding.UTF8.GetBytes(message, 0, message.Length);

				if (stream != null)
					stream.Write(messageBytes, 0, messageBytes.Length);
			}

			tabPageSignUp.Parent = tabControlMain;
			tabPageSignIn.Parent = tabControlMain;

			tabPageCatalog.Parent = null;
			tabPageYourProducts.Parent = null;
			tabPageAddProduct.Parent = null;
			tabPageOnlineClients.Parent = null;

			tableLayoutPanelLogIn.Visible = false;

			textBoxSignUpName.Text = "";
			textBoxSignUpPassword.Text = "";
			textBoxSignUpRepeatPassword.Text = "";
			textBoxSignUpAdminCode.Text = "";

			textBoxSignInName.Text = "";
			textBoxSignInPassword.Text = "";

			labelCatalogBalanceValue.Text = "";

			listBoxCatalog.Items.Clear();

			tcpClient = null;
			client = null;
			stream = null;
		}
	}

	public interface IClient
	{
		string Name { get; set; }
		string Password { get; set; }
	}

	public interface IBuyer : IClient
	{
		decimal Balance { get; set; }
	}

	public interface ISeller : IClient
	{
		List<string> YourProducts { get; set; }
	}

	public interface IAdministrator : IBuyer
	{
		List<string> OnlineClients { get; set; }
	}

	public class Buyer : IBuyer
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public decimal Balance { get; set; }

		public Buyer(string name, string password, decimal balance)
		{
			Name = name;
			Password = password;
			Balance = balance;
		}
	}

	public class Seller : ISeller
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public List<string> YourProducts { get; set; }

		public Seller(string name, string password)
		{
			Name = name;
			Password = password;
			YourProducts = new List<string>();
		}
	}

	public class Administrator : IAdministrator
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public decimal Balance { get; set; }
		public List<string> OnlineClients { get; set; }

		public Administrator(string name, string password)
		{
			Name = name;
			Password = password;
			Balance = -1M;
			OnlineClients = new List<string>();
		}
	}
}
