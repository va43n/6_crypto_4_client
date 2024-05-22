namespace _6_crypto_4_client
{
	partial class MainWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanelMain = new TableLayoutPanel();
			tabControlMain = new TabControl();
			tabPageSignUp = new TabPage();
			tableLayoutPanelSignUp = new TableLayoutPanel();
			tableLayoutPanelSignUpMain = new TableLayoutPanel();
			labelSignUpEnterName = new Label();
			labelSignUpPassword = new Label();
			labelSignUpRepeatPassword = new Label();
			labelChooseRole = new Label();
			labelSignUpButton = new Label();
			textBoxSignUpPassword = new TextBox();
			textBoxSignUpRepeatPassword = new TextBox();
			textBoxSignUpName = new TextBox();
			tableLayoutPanelSignUpChooseRole = new TableLayoutPanel();
			comboBoxChooseRole = new ComboBox();
			textBoxSignUpAdminCode = new TextBox();
			buttonSignUp = new Button();
			tabPageSignIn = new TabPage();
			tableLayoutPanelSignIn = new TableLayoutPanel();
			tableLayoutPanelSignInMain = new TableLayoutPanel();
			labelSignInName = new Label();
			labelSignInPassword = new Label();
			textBoxSignInPassword = new TextBox();
			textBoxSignInName = new TextBox();
			labelSignInButton = new Label();
			buttonSignIn = new Button();
			tabPageCatalog = new TabPage();
			tableLayoutPanelCatalogMain = new TableLayoutPanel();
			buttonCatalogRefresh = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			labelCatalogBalanceValue = new Label();
			labelCatalogBalance = new Label();
			buttonCatalogAddMoneyToBalance = new Button();
			listBoxCatalog = new ListBox();
			tableLayoutPanelCatalogBuy = new TableLayoutPanel();
			buttonCatalogBuy = new Button();
			label1 = new Label();
			tabPageYourProducts = new TabPage();
			tableLayoutPanel2 = new TableLayoutPanel();
			listBoxYourProducts = new ListBox();
			buttonYourProductsRefresh = new Button();
			tableLayoutPanelYourProductsRemoveProduct = new TableLayoutPanel();
			buttonYourProductsRemoveProduct = new Button();
			labelYourProductsRemoveProduct = new Label();
			tabPageAddProduct = new TabPage();
			tableLayoutPanelAddProduct = new TableLayoutPanel();
			tableLayoutPanelAddProductMain = new TableLayoutPanel();
			labelAddProductName = new Label();
			labelAddProductCost = new Label();
			textBoxAddProductCost = new TextBox();
			textBoxAddProductName = new TextBox();
			labelAddProductClickButtton = new Label();
			buttonAddProduct = new Button();
			tabPageOnlineClients = new TabPage();
			tableLayoutPanelOnlineClients = new TableLayoutPanel();
			labelOnlineClients = new Label();
			buttonOnlineClientsRefresh = new Button();
			listBoxOnlineClients = new ListBox();
			tableLayoutPanelLogIn = new TableLayoutPanel();
			labelWelcomeMesage = new Label();
			buttonLogOut = new Button();
			tableLayoutPanelEnterHostPort = new TableLayoutPanel();
			textBoxEnterPort = new TextBox();
			labelEnterHost = new Label();
			labelEnterPort = new Label();
			textBoxEnterHost = new TextBox();
			tableLayoutPanelMain.SuspendLayout();
			tabControlMain.SuspendLayout();
			tabPageSignUp.SuspendLayout();
			tableLayoutPanelSignUp.SuspendLayout();
			tableLayoutPanelSignUpMain.SuspendLayout();
			tableLayoutPanelSignUpChooseRole.SuspendLayout();
			tabPageSignIn.SuspendLayout();
			tableLayoutPanelSignIn.SuspendLayout();
			tableLayoutPanelSignInMain.SuspendLayout();
			tabPageCatalog.SuspendLayout();
			tableLayoutPanelCatalogMain.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanelCatalogBuy.SuspendLayout();
			tabPageYourProducts.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanelYourProductsRemoveProduct.SuspendLayout();
			tabPageAddProduct.SuspendLayout();
			tableLayoutPanelAddProduct.SuspendLayout();
			tableLayoutPanelAddProductMain.SuspendLayout();
			tabPageOnlineClients.SuspendLayout();
			tableLayoutPanelOnlineClients.SuspendLayout();
			tableLayoutPanelLogIn.SuspendLayout();
			tableLayoutPanelEnterHostPort.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelMain.BackColor = Color.White;
			tableLayoutPanelMain.ColumnCount = 1;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelMain.Controls.Add(tabControlMain, 0, 2);
			tableLayoutPanelMain.Controls.Add(tableLayoutPanelLogIn, 0, 1);
			tableLayoutPanelMain.Controls.Add(tableLayoutPanelEnterHostPort, 0, 0);
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Margin = new Padding(0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 3;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
			tableLayoutPanelMain.Size = new Size(624, 441);
			tableLayoutPanelMain.TabIndex = 0;
			// 
			// tabControlMain
			// 
			tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControlMain.Controls.Add(tabPageSignUp);
			tabControlMain.Controls.Add(tabPageSignIn);
			tabControlMain.Controls.Add(tabPageCatalog);
			tabControlMain.Controls.Add(tabPageYourProducts);
			tabControlMain.Controls.Add(tabPageAddProduct);
			tabControlMain.Controls.Add(tabPageOnlineClients);
			tabControlMain.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tabControlMain.Location = new Point(3, 55);
			tabControlMain.Multiline = true;
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(618, 383);
			tabControlMain.TabIndex = 1;
			// 
			// tabPageSignUp
			// 
			tabPageSignUp.BackColor = Color.White;
			tabPageSignUp.Controls.Add(tableLayoutPanelSignUp);
			tabPageSignUp.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tabPageSignUp.Location = new Point(4, 23);
			tabPageSignUp.Name = "tabPageSignUp";
			tabPageSignUp.Padding = new Padding(3);
			tabPageSignUp.Size = new Size(610, 356);
			tabPageSignUp.TabIndex = 0;
			tabPageSignUp.Text = "Регистрация";
			// 
			// tableLayoutPanelSignUp
			// 
			tableLayoutPanelSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSignUp.ColumnCount = 3;
			tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignUp.Controls.Add(tableLayoutPanelSignUpMain, 1, 0);
			tableLayoutPanelSignUp.Location = new Point(0, 0);
			tableLayoutPanelSignUp.Margin = new Padding(0);
			tableLayoutPanelSignUp.Name = "tableLayoutPanelSignUp";
			tableLayoutPanelSignUp.RowCount = 1;
			tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelSignUp.Size = new Size(610, 356);
			tableLayoutPanelSignUp.TabIndex = 0;
			// 
			// tableLayoutPanelSignUpMain
			// 
			tableLayoutPanelSignUpMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSignUpMain.ColumnCount = 1;
			tableLayoutPanelSignUpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelSignUpMain.Controls.Add(labelSignUpEnterName, 0, 0);
			tableLayoutPanelSignUpMain.Controls.Add(labelSignUpPassword, 0, 2);
			tableLayoutPanelSignUpMain.Controls.Add(labelSignUpRepeatPassword, 0, 4);
			tableLayoutPanelSignUpMain.Controls.Add(labelChooseRole, 0, 6);
			tableLayoutPanelSignUpMain.Controls.Add(labelSignUpButton, 0, 8);
			tableLayoutPanelSignUpMain.Controls.Add(textBoxSignUpPassword, 0, 3);
			tableLayoutPanelSignUpMain.Controls.Add(textBoxSignUpRepeatPassword, 0, 5);
			tableLayoutPanelSignUpMain.Controls.Add(textBoxSignUpName, 0, 1);
			tableLayoutPanelSignUpMain.Controls.Add(tableLayoutPanelSignUpChooseRole, 0, 7);
			tableLayoutPanelSignUpMain.Controls.Add(buttonSignUp, 0, 9);
			tableLayoutPanelSignUpMain.Location = new Point(122, 0);
			tableLayoutPanelSignUpMain.Margin = new Padding(0);
			tableLayoutPanelSignUpMain.Name = "tableLayoutPanelSignUpMain";
			tableLayoutPanelSignUpMain.RowCount = 10;
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelSignUpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelSignUpMain.Size = new Size(366, 356);
			tableLayoutPanelSignUpMain.TabIndex = 0;
			// 
			// labelSignUpEnterName
			// 
			labelSignUpEnterName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignUpEnterName.AutoSize = true;
			labelSignUpEnterName.BackColor = Color.FromArgb(230, 230, 230);
			labelSignUpEnterName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignUpEnterName.Location = new Point(3, 3);
			labelSignUpEnterName.Margin = new Padding(3);
			labelSignUpEnterName.Name = "labelSignUpEnterName";
			labelSignUpEnterName.Size = new Size(360, 29);
			labelSignUpEnterName.TabIndex = 0;
			labelSignUpEnterName.Text = "Введите Ваш псевдоним (используйте только латинские буквы, цифры, а также символ \"_\"), мин. - 3 символа, макс. - 20 символов.";
			labelSignUpEnterName.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelSignUpPassword
			// 
			labelSignUpPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignUpPassword.AutoSize = true;
			labelSignUpPassword.BackColor = Color.FromArgb(230, 230, 230);
			labelSignUpPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignUpPassword.Location = new Point(3, 73);
			labelSignUpPassword.Margin = new Padding(3);
			labelSignUpPassword.Name = "labelSignUpPassword";
			labelSignUpPassword.Size = new Size(360, 29);
			labelSignUpPassword.TabIndex = 2;
			labelSignUpPassword.Text = "Придумайте пароль (используйте только латинские буквы и цифры), мин. - 3 символа, макс. - 20 символов";
			labelSignUpPassword.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelSignUpRepeatPassword
			// 
			labelSignUpRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignUpRepeatPassword.AutoSize = true;
			labelSignUpRepeatPassword.BackColor = Color.FromArgb(230, 230, 230);
			labelSignUpRepeatPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignUpRepeatPassword.Location = new Point(3, 143);
			labelSignUpRepeatPassword.Margin = new Padding(3);
			labelSignUpRepeatPassword.Name = "labelSignUpRepeatPassword";
			labelSignUpRepeatPassword.Size = new Size(360, 29);
			labelSignUpRepeatPassword.TabIndex = 3;
			labelSignUpRepeatPassword.Text = "Подтвердите пароль (пароли должны совпадать)";
			labelSignUpRepeatPassword.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelChooseRole
			// 
			labelChooseRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelChooseRole.AutoSize = true;
			labelChooseRole.BackColor = Color.FromArgb(230, 230, 230);
			labelChooseRole.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelChooseRole.Location = new Point(3, 213);
			labelChooseRole.Margin = new Padding(3);
			labelChooseRole.Name = "labelChooseRole";
			labelChooseRole.Size = new Size(360, 29);
			labelChooseRole.TabIndex = 4;
			labelChooseRole.Text = "Выберете одну из предложенных ролей";
			labelChooseRole.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelSignUpButton
			// 
			labelSignUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignUpButton.AutoSize = true;
			labelSignUpButton.BackColor = Color.FromArgb(230, 230, 230);
			labelSignUpButton.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignUpButton.Location = new Point(3, 283);
			labelSignUpButton.Margin = new Padding(3);
			labelSignUpButton.Name = "labelSignUpButton";
			labelSignUpButton.Size = new Size(360, 29);
			labelSignUpButton.TabIndex = 5;
			labelSignUpButton.Text = "Нажмите на кнопку, чтобы зарегистрироваться";
			labelSignUpButton.TextAlign = ContentAlignment.BottomCenter;
			// 
			// textBoxSignUpPassword
			// 
			textBoxSignUpPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignUpPassword.BackColor = Color.White;
			textBoxSignUpPassword.BorderStyle = BorderStyle.FixedSingle;
			textBoxSignUpPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignUpPassword.Location = new Point(3, 108);
			textBoxSignUpPassword.MaxLength = 20;
			textBoxSignUpPassword.Name = "textBoxSignUpPassword";
			textBoxSignUpPassword.Size = new Size(360, 22);
			textBoxSignUpPassword.TabIndex = 6;
			// 
			// textBoxSignUpRepeatPassword
			// 
			textBoxSignUpRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignUpRepeatPassword.BackColor = Color.White;
			textBoxSignUpRepeatPassword.BorderStyle = BorderStyle.FixedSingle;
			textBoxSignUpRepeatPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignUpRepeatPassword.Location = new Point(3, 178);
			textBoxSignUpRepeatPassword.MaxLength = 20;
			textBoxSignUpRepeatPassword.Name = "textBoxSignUpRepeatPassword";
			textBoxSignUpRepeatPassword.Size = new Size(360, 22);
			textBoxSignUpRepeatPassword.TabIndex = 7;
			// 
			// textBoxSignUpName
			// 
			textBoxSignUpName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignUpName.BackColor = Color.White;
			textBoxSignUpName.BorderStyle = BorderStyle.FixedSingle;
			textBoxSignUpName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignUpName.Location = new Point(3, 38);
			textBoxSignUpName.MaxLength = 20;
			textBoxSignUpName.Name = "textBoxSignUpName";
			textBoxSignUpName.Size = new Size(360, 22);
			textBoxSignUpName.TabIndex = 8;
			// 
			// tableLayoutPanelSignUpChooseRole
			// 
			tableLayoutPanelSignUpChooseRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSignUpChooseRole.ColumnCount = 2;
			tableLayoutPanelSignUpChooseRole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanelSignUpChooseRole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanelSignUpChooseRole.Controls.Add(comboBoxChooseRole, 0, 0);
			tableLayoutPanelSignUpChooseRole.Controls.Add(textBoxSignUpAdminCode, 1, 0);
			tableLayoutPanelSignUpChooseRole.Location = new Point(0, 245);
			tableLayoutPanelSignUpChooseRole.Margin = new Padding(0);
			tableLayoutPanelSignUpChooseRole.Name = "tableLayoutPanelSignUpChooseRole";
			tableLayoutPanelSignUpChooseRole.RowCount = 1;
			tableLayoutPanelSignUpChooseRole.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelSignUpChooseRole.Size = new Size(366, 35);
			tableLayoutPanelSignUpChooseRole.TabIndex = 10;
			// 
			// comboBoxChooseRole
			// 
			comboBoxChooseRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			comboBoxChooseRole.BackColor = Color.FromArgb(230, 230, 230);
			comboBoxChooseRole.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxChooseRole.FlatStyle = FlatStyle.Flat;
			comboBoxChooseRole.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			comboBoxChooseRole.ForeColor = SystemColors.WindowText;
			comboBoxChooseRole.FormattingEnabled = true;
			comboBoxChooseRole.Items.AddRange(new object[] { "Покупатель", "Продавец", "Администратор" });
			comboBoxChooseRole.Location = new Point(3, 3);
			comboBoxChooseRole.Name = "comboBoxChooseRole";
			comboBoxChooseRole.Size = new Size(213, 22);
			comboBoxChooseRole.TabIndex = 9;
			// 
			// textBoxSignUpAdminCode
			// 
			textBoxSignUpAdminCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignUpAdminCode.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignUpAdminCode.Location = new Point(222, 3);
			textBoxSignUpAdminCode.MaxLength = 50;
			textBoxSignUpAdminCode.Name = "textBoxSignUpAdminCode";
			textBoxSignUpAdminCode.Size = new Size(141, 22);
			textBoxSignUpAdminCode.TabIndex = 10;
			textBoxSignUpAdminCode.Text = "Введите код";
			// 
			// buttonSignUp
			// 
			buttonSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonSignUp.BackColor = Color.FromArgb(230, 255, 255);
			buttonSignUp.BackgroundImageLayout = ImageLayout.None;
			buttonSignUp.FlatStyle = FlatStyle.Popup;
			buttonSignUp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonSignUp.Location = new Point(3, 318);
			buttonSignUp.Name = "buttonSignUp";
			buttonSignUp.Size = new Size(360, 35);
			buttonSignUp.TabIndex = 11;
			buttonSignUp.Text = "Зарегистрироваться";
			buttonSignUp.UseVisualStyleBackColor = false;
			// 
			// tabPageSignIn
			// 
			tabPageSignIn.Controls.Add(tableLayoutPanelSignIn);
			tabPageSignIn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tabPageSignIn.Location = new Point(4, 23);
			tabPageSignIn.Name = "tabPageSignIn";
			tabPageSignIn.Padding = new Padding(3);
			tabPageSignIn.Size = new Size(610, 356);
			tabPageSignIn.TabIndex = 1;
			tabPageSignIn.Text = "Вход";
			tabPageSignIn.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelSignIn
			// 
			tableLayoutPanelSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSignIn.ColumnCount = 3;
			tableLayoutPanelSignIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanelSignIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignIn.Controls.Add(tableLayoutPanelSignInMain, 1, 1);
			tableLayoutPanelSignIn.Location = new Point(0, 0);
			tableLayoutPanelSignIn.Margin = new Padding(0);
			tableLayoutPanelSignIn.Name = "tableLayoutPanelSignIn";
			tableLayoutPanelSignIn.RowCount = 3;
			tableLayoutPanelSignIn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignIn.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanelSignIn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelSignIn.Size = new Size(610, 356);
			tableLayoutPanelSignIn.TabIndex = 1;
			// 
			// tableLayoutPanelSignInMain
			// 
			tableLayoutPanelSignInMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSignInMain.ColumnCount = 1;
			tableLayoutPanelSignInMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelSignInMain.Controls.Add(labelSignInName, 0, 0);
			tableLayoutPanelSignInMain.Controls.Add(labelSignInPassword, 0, 2);
			tableLayoutPanelSignInMain.Controls.Add(textBoxSignInPassword, 0, 3);
			tableLayoutPanelSignInMain.Controls.Add(textBoxSignInName, 0, 1);
			tableLayoutPanelSignInMain.Controls.Add(labelSignInButton, 0, 4);
			tableLayoutPanelSignInMain.Controls.Add(buttonSignIn, 0, 5);
			tableLayoutPanelSignInMain.Location = new Point(122, 71);
			tableLayoutPanelSignInMain.Margin = new Padding(0);
			tableLayoutPanelSignInMain.Name = "tableLayoutPanelSignInMain";
			tableLayoutPanelSignInMain.RowCount = 6;
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelSignInMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelSignInMain.Size = new Size(366, 213);
			tableLayoutPanelSignInMain.TabIndex = 0;
			// 
			// labelSignInName
			// 
			labelSignInName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignInName.AutoSize = true;
			labelSignInName.BackColor = Color.FromArgb(230, 230, 230);
			labelSignInName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignInName.Location = new Point(3, 3);
			labelSignInName.Margin = new Padding(3);
			labelSignInName.Name = "labelSignInName";
			labelSignInName.Size = new Size(360, 29);
			labelSignInName.TabIndex = 0;
			labelSignInName.Text = "Введите Ваш псевдоним";
			labelSignInName.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelSignInPassword
			// 
			labelSignInPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignInPassword.AutoSize = true;
			labelSignInPassword.BackColor = Color.FromArgb(230, 230, 230);
			labelSignInPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignInPassword.Location = new Point(3, 73);
			labelSignInPassword.Margin = new Padding(3);
			labelSignInPassword.Name = "labelSignInPassword";
			labelSignInPassword.Size = new Size(360, 29);
			labelSignInPassword.TabIndex = 2;
			labelSignInPassword.Text = "Введите Ваш пароль";
			labelSignInPassword.TextAlign = ContentAlignment.BottomCenter;
			// 
			// textBoxSignInPassword
			// 
			textBoxSignInPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignInPassword.BackColor = Color.White;
			textBoxSignInPassword.BorderStyle = BorderStyle.FixedSingle;
			textBoxSignInPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignInPassword.Location = new Point(3, 108);
			textBoxSignInPassword.MaxLength = 20;
			textBoxSignInPassword.Name = "textBoxSignInPassword";
			textBoxSignInPassword.Size = new Size(360, 22);
			textBoxSignInPassword.TabIndex = 6;
			// 
			// textBoxSignInName
			// 
			textBoxSignInName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxSignInName.BackColor = Color.White;
			textBoxSignInName.BorderStyle = BorderStyle.FixedSingle;
			textBoxSignInName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxSignInName.Location = new Point(3, 38);
			textBoxSignInName.MaxLength = 20;
			textBoxSignInName.Name = "textBoxSignInName";
			textBoxSignInName.Size = new Size(360, 22);
			textBoxSignInName.TabIndex = 8;
			// 
			// labelSignInButton
			// 
			labelSignInButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelSignInButton.AutoSize = true;
			labelSignInButton.BackColor = Color.FromArgb(230, 230, 230);
			labelSignInButton.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSignInButton.Location = new Point(3, 143);
			labelSignInButton.Margin = new Padding(3);
			labelSignInButton.Name = "labelSignInButton";
			labelSignInButton.Size = new Size(360, 29);
			labelSignInButton.TabIndex = 5;
			labelSignInButton.Text = "Нажмите на кнопку, чтобы войти";
			labelSignInButton.TextAlign = ContentAlignment.BottomCenter;
			// 
			// buttonSignIn
			// 
			buttonSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonSignIn.BackColor = Color.FromArgb(230, 255, 255);
			buttonSignIn.BackgroundImageLayout = ImageLayout.None;
			buttonSignIn.FlatStyle = FlatStyle.Popup;
			buttonSignIn.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonSignIn.Location = new Point(3, 178);
			buttonSignIn.Name = "buttonSignIn";
			buttonSignIn.Size = new Size(360, 32);
			buttonSignIn.TabIndex = 11;
			buttonSignIn.Text = "Войти";
			buttonSignIn.UseVisualStyleBackColor = false;
			// 
			// tabPageCatalog
			// 
			tabPageCatalog.Controls.Add(tableLayoutPanelCatalogMain);
			tabPageCatalog.Location = new Point(4, 23);
			tabPageCatalog.Name = "tabPageCatalog";
			tabPageCatalog.Size = new Size(610, 356);
			tabPageCatalog.TabIndex = 2;
			tabPageCatalog.Text = "Каталог";
			tabPageCatalog.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelCatalogMain
			// 
			tableLayoutPanelCatalogMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelCatalogMain.ColumnCount = 1;
			tableLayoutPanelCatalogMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelCatalogMain.Controls.Add(buttonCatalogRefresh, 0, 1);
			tableLayoutPanelCatalogMain.Controls.Add(tableLayoutPanel1, 0, 0);
			tableLayoutPanelCatalogMain.Controls.Add(listBoxCatalog, 0, 2);
			tableLayoutPanelCatalogMain.Controls.Add(tableLayoutPanelCatalogBuy, 0, 3);
			tableLayoutPanelCatalogMain.Location = new Point(0, 0);
			tableLayoutPanelCatalogMain.Margin = new Padding(0);
			tableLayoutPanelCatalogMain.Name = "tableLayoutPanelCatalogMain";
			tableLayoutPanelCatalogMain.RowCount = 4;
			tableLayoutPanelCatalogMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelCatalogMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelCatalogMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanelCatalogMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelCatalogMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelCatalogMain.Size = new Size(610, 356);
			tableLayoutPanelCatalogMain.TabIndex = 0;
			// 
			// buttonCatalogRefresh
			// 
			buttonCatalogRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCatalogRefresh.BackColor = Color.FromArgb(230, 255, 255);
			buttonCatalogRefresh.FlatStyle = FlatStyle.Popup;
			buttonCatalogRefresh.Location = new Point(3, 38);
			buttonCatalogRefresh.Name = "buttonCatalogRefresh";
			buttonCatalogRefresh.Size = new Size(604, 29);
			buttonCatalogRefresh.TabIndex = 3;
			buttonCatalogRefresh.Text = "Обновить каталог";
			buttonCatalogRefresh.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Controls.Add(labelCatalogBalanceValue, 1, 0);
			tableLayoutPanel1.Controls.Add(labelCatalogBalance, 0, 0);
			tableLayoutPanel1.Controls.Add(buttonCatalogAddMoneyToBalance, 2, 0);
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(610, 35);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// labelCatalogBalanceValue
			// 
			labelCatalogBalanceValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelCatalogBalanceValue.AutoSize = true;
			labelCatalogBalanceValue.BackColor = Color.FromArgb(230, 230, 230);
			labelCatalogBalanceValue.Location = new Point(206, 3);
			labelCatalogBalanceValue.Margin = new Padding(3);
			labelCatalogBalanceValue.Name = "labelCatalogBalanceValue";
			labelCatalogBalanceValue.Size = new Size(197, 29);
			labelCatalogBalanceValue.TabIndex = 1;
			labelCatalogBalanceValue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelCatalogBalance
			// 
			labelCatalogBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelCatalogBalance.AutoSize = true;
			labelCatalogBalance.BackColor = Color.FromArgb(230, 230, 230);
			labelCatalogBalance.Location = new Point(3, 3);
			labelCatalogBalance.Margin = new Padding(3);
			labelCatalogBalance.Name = "labelCatalogBalance";
			labelCatalogBalance.Size = new Size(197, 29);
			labelCatalogBalance.TabIndex = 0;
			labelCatalogBalance.Text = "Баланс:";
			labelCatalogBalance.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonCatalogAddMoneyToBalance
			// 
			buttonCatalogAddMoneyToBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCatalogAddMoneyToBalance.BackColor = Color.FromArgb(230, 255, 255);
			buttonCatalogAddMoneyToBalance.FlatStyle = FlatStyle.Popup;
			buttonCatalogAddMoneyToBalance.Location = new Point(409, 3);
			buttonCatalogAddMoneyToBalance.Name = "buttonCatalogAddMoneyToBalance";
			buttonCatalogAddMoneyToBalance.Size = new Size(198, 29);
			buttonCatalogAddMoneyToBalance.TabIndex = 2;
			buttonCatalogAddMoneyToBalance.Text = "Пополнить баланс";
			buttonCatalogAddMoneyToBalance.UseVisualStyleBackColor = false;
			// 
			// listBoxCatalog
			// 
			listBoxCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listBoxCatalog.BackColor = Color.White;
			listBoxCatalog.FormattingEnabled = true;
			listBoxCatalog.HorizontalScrollbar = true;
			listBoxCatalog.ItemHeight = 14;
			listBoxCatalog.Location = new Point(3, 73);
			listBoxCatalog.Name = "listBoxCatalog";
			listBoxCatalog.Size = new Size(604, 242);
			listBoxCatalog.TabIndex = 1;
			// 
			// tableLayoutPanelCatalogBuy
			// 
			tableLayoutPanelCatalogBuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelCatalogBuy.ColumnCount = 2;
			tableLayoutPanelCatalogBuy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanelCatalogBuy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelCatalogBuy.Controls.Add(buttonCatalogBuy, 1, 0);
			tableLayoutPanelCatalogBuy.Controls.Add(label1, 0, 0);
			tableLayoutPanelCatalogBuy.Location = new Point(0, 319);
			tableLayoutPanelCatalogBuy.Margin = new Padding(0);
			tableLayoutPanelCatalogBuy.Name = "tableLayoutPanelCatalogBuy";
			tableLayoutPanelCatalogBuy.RowCount = 1;
			tableLayoutPanelCatalogBuy.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelCatalogBuy.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelCatalogBuy.Size = new Size(610, 37);
			tableLayoutPanelCatalogBuy.TabIndex = 2;
			// 
			// buttonCatalogBuy
			// 
			buttonCatalogBuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCatalogBuy.BackColor = Color.FromArgb(230, 255, 255);
			buttonCatalogBuy.FlatStyle = FlatStyle.Popup;
			buttonCatalogBuy.Location = new Point(491, 3);
			buttonCatalogBuy.Name = "buttonCatalogBuy";
			buttonCatalogBuy.Size = new Size(116, 31);
			buttonCatalogBuy.TabIndex = 3;
			buttonCatalogBuy.Text = "Купить";
			buttonCatalogBuy.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(230, 230, 230);
			label1.Location = new Point(3, 3);
			label1.Margin = new Padding(3);
			label1.Name = "label1";
			label1.Size = new Size(482, 31);
			label1.TabIndex = 0;
			label1.Text = "Чтобы купить товар, выберете его в списке и нажмите кнопку \"Купить\"";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tabPageYourProducts
			// 
			tabPageYourProducts.Controls.Add(tableLayoutPanel2);
			tabPageYourProducts.Location = new Point(4, 23);
			tabPageYourProducts.Name = "tabPageYourProducts";
			tabPageYourProducts.Size = new Size(610, 356);
			tabPageYourProducts.TabIndex = 3;
			tabPageYourProducts.Text = "Ваши Товары";
			tabPageYourProducts.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(listBoxYourProducts, 0, 1);
			tableLayoutPanel2.Controls.Add(buttonYourProductsRefresh, 0, 0);
			tableLayoutPanel2.Controls.Add(tableLayoutPanelYourProductsRemoveProduct, 0, 2);
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Margin = new Padding(0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(610, 356);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// listBoxYourProducts
			// 
			listBoxYourProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listBoxYourProducts.BackColor = Color.White;
			listBoxYourProducts.FormattingEnabled = true;
			listBoxYourProducts.HorizontalScrollbar = true;
			listBoxYourProducts.ItemHeight = 14;
			listBoxYourProducts.Location = new Point(3, 38);
			listBoxYourProducts.Name = "listBoxYourProducts";
			listBoxYourProducts.Size = new Size(604, 270);
			listBoxYourProducts.TabIndex = 2;
			// 
			// buttonYourProductsRefresh
			// 
			buttonYourProductsRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonYourProductsRefresh.BackColor = Color.FromArgb(230, 255, 255);
			buttonYourProductsRefresh.FlatStyle = FlatStyle.Popup;
			buttonYourProductsRefresh.Location = new Point(3, 3);
			buttonYourProductsRefresh.Name = "buttonYourProductsRefresh";
			buttonYourProductsRefresh.Size = new Size(604, 29);
			buttonYourProductsRefresh.TabIndex = 4;
			buttonYourProductsRefresh.Text = "Обновить список Ваших товаров";
			buttonYourProductsRefresh.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanelYourProductsRemoveProduct
			// 
			tableLayoutPanelYourProductsRemoveProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelYourProductsRemoveProduct.ColumnCount = 2;
			tableLayoutPanelYourProductsRemoveProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanelYourProductsRemoveProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelYourProductsRemoveProduct.Controls.Add(buttonYourProductsRemoveProduct, 1, 0);
			tableLayoutPanelYourProductsRemoveProduct.Controls.Add(labelYourProductsRemoveProduct, 0, 0);
			tableLayoutPanelYourProductsRemoveProduct.Location = new Point(0, 319);
			tableLayoutPanelYourProductsRemoveProduct.Margin = new Padding(0);
			tableLayoutPanelYourProductsRemoveProduct.Name = "tableLayoutPanelYourProductsRemoveProduct";
			tableLayoutPanelYourProductsRemoveProduct.RowCount = 1;
			tableLayoutPanelYourProductsRemoveProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelYourProductsRemoveProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelYourProductsRemoveProduct.Size = new Size(610, 37);
			tableLayoutPanelYourProductsRemoveProduct.TabIndex = 3;
			// 
			// buttonYourProductsRemoveProduct
			// 
			buttonYourProductsRemoveProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonYourProductsRemoveProduct.BackColor = Color.FromArgb(230, 255, 255);
			buttonYourProductsRemoveProduct.FlatStyle = FlatStyle.Popup;
			buttonYourProductsRemoveProduct.Location = new Point(491, 3);
			buttonYourProductsRemoveProduct.Name = "buttonYourProductsRemoveProduct";
			buttonYourProductsRemoveProduct.Size = new Size(116, 31);
			buttonYourProductsRemoveProduct.TabIndex = 3;
			buttonYourProductsRemoveProduct.Text = "Удалить";
			buttonYourProductsRemoveProduct.UseVisualStyleBackColor = false;
			// 
			// labelYourProductsRemoveProduct
			// 
			labelYourProductsRemoveProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelYourProductsRemoveProduct.AutoSize = true;
			labelYourProductsRemoveProduct.BackColor = Color.FromArgb(230, 230, 230);
			labelYourProductsRemoveProduct.Location = new Point(3, 3);
			labelYourProductsRemoveProduct.Margin = new Padding(3);
			labelYourProductsRemoveProduct.Name = "labelYourProductsRemoveProduct";
			labelYourProductsRemoveProduct.Size = new Size(482, 31);
			labelYourProductsRemoveProduct.TabIndex = 0;
			labelYourProductsRemoveProduct.Text = "Чтобы удалить Ваш товар из магазина, выберете его и нажмите \"Удалить\"";
			labelYourProductsRemoveProduct.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tabPageAddProduct
			// 
			tabPageAddProduct.Controls.Add(tableLayoutPanelAddProduct);
			tabPageAddProduct.Location = new Point(4, 23);
			tabPageAddProduct.Name = "tabPageAddProduct";
			tabPageAddProduct.Size = new Size(610, 356);
			tabPageAddProduct.TabIndex = 4;
			tabPageAddProduct.Text = "Добавить товар";
			tabPageAddProduct.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelAddProduct
			// 
			tableLayoutPanelAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelAddProduct.ColumnCount = 3;
			tableLayoutPanelAddProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelAddProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanelAddProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelAddProduct.Controls.Add(tableLayoutPanelAddProductMain, 1, 1);
			tableLayoutPanelAddProduct.Location = new Point(0, 0);
			tableLayoutPanelAddProduct.Margin = new Padding(0);
			tableLayoutPanelAddProduct.Name = "tableLayoutPanelAddProduct";
			tableLayoutPanelAddProduct.RowCount = 3;
			tableLayoutPanelAddProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelAddProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
			tableLayoutPanelAddProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelAddProduct.Size = new Size(618, 364);
			tableLayoutPanelAddProduct.TabIndex = 2;
			// 
			// tableLayoutPanelAddProductMain
			// 
			tableLayoutPanelAddProductMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelAddProductMain.ColumnCount = 1;
			tableLayoutPanelAddProductMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelAddProductMain.Controls.Add(labelAddProductName, 0, 0);
			tableLayoutPanelAddProductMain.Controls.Add(labelAddProductCost, 0, 2);
			tableLayoutPanelAddProductMain.Controls.Add(textBoxAddProductCost, 0, 3);
			tableLayoutPanelAddProductMain.Controls.Add(textBoxAddProductName, 0, 1);
			tableLayoutPanelAddProductMain.Controls.Add(labelAddProductClickButtton, 0, 4);
			tableLayoutPanelAddProductMain.Controls.Add(buttonAddProduct, 0, 5);
			tableLayoutPanelAddProductMain.Location = new Point(123, 36);
			tableLayoutPanelAddProductMain.Margin = new Padding(0);
			tableLayoutPanelAddProductMain.Name = "tableLayoutPanelAddProductMain";
			tableLayoutPanelAddProductMain.RowCount = 6;
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelAddProductMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelAddProductMain.Size = new Size(370, 291);
			tableLayoutPanelAddProductMain.TabIndex = 0;
			// 
			// labelAddProductName
			// 
			labelAddProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelAddProductName.AutoSize = true;
			labelAddProductName.BackColor = Color.FromArgb(230, 230, 230);
			labelAddProductName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelAddProductName.Location = new Point(3, 3);
			labelAddProductName.Margin = new Padding(3);
			labelAddProductName.Name = "labelAddProductName";
			labelAddProductName.Size = new Size(364, 42);
			labelAddProductName.TabIndex = 0;
			labelAddProductName.Text = "Введите название товара (используйте только латинские и кириллические буквы, а также цифры и \"пробел\"), мин. - 3 символа, макс. - 50 символов";
			labelAddProductName.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelAddProductCost
			// 
			labelAddProductCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelAddProductCost.AutoSize = true;
			labelAddProductCost.BackColor = Color.FromArgb(230, 230, 230);
			labelAddProductCost.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelAddProductCost.Location = new Point(3, 99);
			labelAddProductCost.Margin = new Padding(3);
			labelAddProductCost.Name = "labelAddProductCost";
			labelAddProductCost.Size = new Size(364, 42);
			labelAddProductCost.TabIndex = 2;
			labelAddProductCost.Text = "Введите цену товара (используйте только цифры и знак \".\" для разделения целой части числа от дробной), мин. цена - 1, макс. цена - 999999999999";
			labelAddProductCost.TextAlign = ContentAlignment.BottomCenter;
			// 
			// textBoxAddProductCost
			// 
			textBoxAddProductCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxAddProductCost.BackColor = Color.White;
			textBoxAddProductCost.BorderStyle = BorderStyle.FixedSingle;
			textBoxAddProductCost.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxAddProductCost.Location = new Point(3, 147);
			textBoxAddProductCost.MaxLength = 10000;
			textBoxAddProductCost.Name = "textBoxAddProductCost";
			textBoxAddProductCost.Size = new Size(364, 22);
			textBoxAddProductCost.TabIndex = 6;
			// 
			// textBoxAddProductName
			// 
			textBoxAddProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxAddProductName.BackColor = Color.White;
			textBoxAddProductName.BorderStyle = BorderStyle.FixedSingle;
			textBoxAddProductName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxAddProductName.Location = new Point(3, 51);
			textBoxAddProductName.MaxLength = 50;
			textBoxAddProductName.Name = "textBoxAddProductName";
			textBoxAddProductName.Size = new Size(364, 22);
			textBoxAddProductName.TabIndex = 8;
			// 
			// labelAddProductClickButtton
			// 
			labelAddProductClickButtton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelAddProductClickButtton.AutoSize = true;
			labelAddProductClickButtton.BackColor = Color.FromArgb(230, 230, 230);
			labelAddProductClickButtton.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelAddProductClickButtton.Location = new Point(3, 195);
			labelAddProductClickButtton.Margin = new Padding(3);
			labelAddProductClickButtton.Name = "labelAddProductClickButtton";
			labelAddProductClickButtton.Size = new Size(364, 42);
			labelAddProductClickButtton.TabIndex = 5;
			labelAddProductClickButtton.Text = "Нажмите на кнопку, чтобы добавить товар в каталог";
			labelAddProductClickButtton.TextAlign = ContentAlignment.BottomCenter;
			// 
			// buttonAddProduct
			// 
			buttonAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonAddProduct.BackColor = Color.FromArgb(230, 255, 255);
			buttonAddProduct.BackgroundImageLayout = ImageLayout.None;
			buttonAddProduct.FlatStyle = FlatStyle.Popup;
			buttonAddProduct.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonAddProduct.Location = new Point(3, 243);
			buttonAddProduct.Name = "buttonAddProduct";
			buttonAddProduct.Size = new Size(364, 45);
			buttonAddProduct.TabIndex = 11;
			buttonAddProduct.Text = "Добавить товар";
			buttonAddProduct.UseVisualStyleBackColor = false;
			// 
			// tabPageOnlineClients
			// 
			tabPageOnlineClients.Controls.Add(tableLayoutPanelOnlineClients);
			tabPageOnlineClients.Location = new Point(4, 23);
			tabPageOnlineClients.Name = "tabPageOnlineClients";
			tabPageOnlineClients.Size = new Size(610, 356);
			tabPageOnlineClients.TabIndex = 5;
			tabPageOnlineClients.Text = "Пользователи онлайн";
			tabPageOnlineClients.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelOnlineClients
			// 
			tableLayoutPanelOnlineClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelOnlineClients.ColumnCount = 1;
			tableLayoutPanelOnlineClients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelOnlineClients.Controls.Add(labelOnlineClients, 0, 0);
			tableLayoutPanelOnlineClients.Controls.Add(buttonOnlineClientsRefresh, 0, 1);
			tableLayoutPanelOnlineClients.Controls.Add(listBoxOnlineClients, 0, 2);
			tableLayoutPanelOnlineClients.Location = new Point(0, 0);
			tableLayoutPanelOnlineClients.Margin = new Padding(0);
			tableLayoutPanelOnlineClients.Name = "tableLayoutPanelOnlineClients";
			tableLayoutPanelOnlineClients.RowCount = 3;
			tableLayoutPanelOnlineClients.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelOnlineClients.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanelOnlineClients.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
			tableLayoutPanelOnlineClients.Size = new Size(610, 356);
			tableLayoutPanelOnlineClients.TabIndex = 0;
			// 
			// labelOnlineClients
			// 
			labelOnlineClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelOnlineClients.AutoSize = true;
			labelOnlineClients.BackColor = Color.FromArgb(230, 230, 230);
			labelOnlineClients.Location = new Point(3, 3);
			labelOnlineClients.Margin = new Padding(3);
			labelOnlineClients.Name = "labelOnlineClients";
			labelOnlineClients.Size = new Size(604, 29);
			labelOnlineClients.TabIndex = 0;
			labelOnlineClients.Text = "Здесь вы можете увидеть Пользователей, которые находятся онлайн";
			labelOnlineClients.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonOnlineClientsRefresh
			// 
			buttonOnlineClientsRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonOnlineClientsRefresh.BackColor = Color.FromArgb(230, 255, 255);
			buttonOnlineClientsRefresh.FlatStyle = FlatStyle.Popup;
			buttonOnlineClientsRefresh.Location = new Point(3, 38);
			buttonOnlineClientsRefresh.Name = "buttonOnlineClientsRefresh";
			buttonOnlineClientsRefresh.Size = new Size(604, 29);
			buttonOnlineClientsRefresh.TabIndex = 5;
			buttonOnlineClientsRefresh.Text = "Обновить список Пользователей онлайн";
			buttonOnlineClientsRefresh.UseVisualStyleBackColor = false;
			// 
			// listBoxOnlineClients
			// 
			listBoxOnlineClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listBoxOnlineClients.BackColor = Color.White;
			listBoxOnlineClients.FormattingEnabled = true;
			listBoxOnlineClients.HorizontalScrollbar = true;
			listBoxOnlineClients.ItemHeight = 14;
			listBoxOnlineClients.Location = new Point(3, 73);
			listBoxOnlineClients.Name = "listBoxOnlineClients";
			listBoxOnlineClients.Size = new Size(604, 270);
			listBoxOnlineClients.TabIndex = 1;
			// 
			// tableLayoutPanelLogIn
			// 
			tableLayoutPanelLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelLogIn.ColumnCount = 2;
			tableLayoutPanelLogIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanelLogIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanelLogIn.Controls.Add(labelWelcomeMesage, 0, 0);
			tableLayoutPanelLogIn.Controls.Add(buttonLogOut, 1, 0);
			tableLayoutPanelLogIn.Location = new Point(0, 26);
			tableLayoutPanelLogIn.Margin = new Padding(0);
			tableLayoutPanelLogIn.Name = "tableLayoutPanelLogIn";
			tableLayoutPanelLogIn.RowCount = 1;
			tableLayoutPanelLogIn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelLogIn.Size = new Size(624, 26);
			tableLayoutPanelLogIn.TabIndex = 2;
			// 
			// labelWelcomeMesage
			// 
			labelWelcomeMesage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelWelcomeMesage.AutoSize = true;
			labelWelcomeMesage.BackColor = Color.FromArgb(230, 230, 230);
			labelWelcomeMesage.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelWelcomeMesage.Location = new Point(3, 3);
			labelWelcomeMesage.Margin = new Padding(3);
			labelWelcomeMesage.Name = "labelWelcomeMesage";
			labelWelcomeMesage.Size = new Size(493, 20);
			labelWelcomeMesage.TabIndex = 0;
			labelWelcomeMesage.Text = "Добро пожаловать, ...";
			labelWelcomeMesage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonLogOut
			// 
			buttonLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonLogOut.BackColor = Color.FromArgb(230, 255, 255);
			buttonLogOut.FlatStyle = FlatStyle.Popup;
			buttonLogOut.Location = new Point(502, 3);
			buttonLogOut.Name = "buttonLogOut";
			buttonLogOut.Size = new Size(119, 20);
			buttonLogOut.TabIndex = 1;
			buttonLogOut.Text = "Выйти";
			buttonLogOut.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanelEnterHostPort
			// 
			tableLayoutPanelEnterHostPort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelEnterHostPort.ColumnCount = 4;
			tableLayoutPanelEnterHostPort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0167351F));
			tableLayoutPanelEnterHostPort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0167351F));
			tableLayoutPanelEnterHostPort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0167351F));
			tableLayoutPanelEnterHostPort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9497967F));
			tableLayoutPanelEnterHostPort.Controls.Add(textBoxEnterPort, 3, 0);
			tableLayoutPanelEnterHostPort.Controls.Add(labelEnterHost, 0, 0);
			tableLayoutPanelEnterHostPort.Controls.Add(labelEnterPort, 2, 0);
			tableLayoutPanelEnterHostPort.Controls.Add(textBoxEnterHost, 1, 0);
			tableLayoutPanelEnterHostPort.Location = new Point(0, 0);
			tableLayoutPanelEnterHostPort.Margin = new Padding(0);
			tableLayoutPanelEnterHostPort.Name = "tableLayoutPanelEnterHostPort";
			tableLayoutPanelEnterHostPort.RowCount = 1;
			tableLayoutPanelEnterHostPort.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelEnterHostPort.Size = new Size(624, 26);
			tableLayoutPanelEnterHostPort.TabIndex = 3;
			// 
			// textBoxEnterPort
			// 
			textBoxEnterPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBoxEnterPort.BackColor = Color.White;
			textBoxEnterPort.Location = new Point(471, 3);
			textBoxEnterPort.Name = "textBoxEnterPort";
			textBoxEnterPort.Size = new Size(150, 23);
			textBoxEnterPort.TabIndex = 3;
			textBoxEnterPort.Text = "8080";
			// 
			// labelEnterHost
			// 
			labelEnterHost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelEnterHost.AutoSize = true;
			labelEnterHost.BackColor = Color.FromArgb(230, 230, 230);
			labelEnterHost.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelEnterHost.Location = new Point(3, 3);
			labelEnterHost.Margin = new Padding(3);
			labelEnterHost.Name = "labelEnterHost";
			labelEnterHost.Size = new Size(150, 20);
			labelEnterHost.TabIndex = 0;
			labelEnterHost.Text = "Введите хост:";
			labelEnterHost.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelEnterPort
			// 
			labelEnterPort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelEnterPort.AutoSize = true;
			labelEnterPort.BackColor = Color.FromArgb(230, 230, 230);
			labelEnterPort.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelEnterPort.Location = new Point(315, 3);
			labelEnterPort.Margin = new Padding(3);
			labelEnterPort.Name = "labelEnterPort";
			labelEnterPort.Size = new Size(150, 20);
			labelEnterPort.TabIndex = 1;
			labelEnterPort.Text = "Введите порт:";
			labelEnterPort.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBoxEnterHost
			// 
			textBoxEnterHost.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBoxEnterHost.BackColor = Color.White;
			textBoxEnterHost.Location = new Point(159, 3);
			textBoxEnterHost.Name = "textBoxEnterHost";
			textBoxEnterHost.Size = new Size(150, 23);
			textBoxEnterHost.TabIndex = 2;
			textBoxEnterHost.Text = "127.0.0.1";
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(624, 441);
			Controls.Add(tableLayoutPanelMain);
			MinimumSize = new Size(640, 480);
			Name = "MainWindow";
			Text = "Магазин";
			tableLayoutPanelMain.ResumeLayout(false);
			tabControlMain.ResumeLayout(false);
			tabPageSignUp.ResumeLayout(false);
			tableLayoutPanelSignUp.ResumeLayout(false);
			tableLayoutPanelSignUpMain.ResumeLayout(false);
			tableLayoutPanelSignUpMain.PerformLayout();
			tableLayoutPanelSignUpChooseRole.ResumeLayout(false);
			tableLayoutPanelSignUpChooseRole.PerformLayout();
			tabPageSignIn.ResumeLayout(false);
			tableLayoutPanelSignIn.ResumeLayout(false);
			tableLayoutPanelSignInMain.ResumeLayout(false);
			tableLayoutPanelSignInMain.PerformLayout();
			tabPageCatalog.ResumeLayout(false);
			tableLayoutPanelCatalogMain.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanelCatalogBuy.ResumeLayout(false);
			tableLayoutPanelCatalogBuy.PerformLayout();
			tabPageYourProducts.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanelYourProductsRemoveProduct.ResumeLayout(false);
			tableLayoutPanelYourProductsRemoveProduct.PerformLayout();
			tabPageAddProduct.ResumeLayout(false);
			tableLayoutPanelAddProduct.ResumeLayout(false);
			tableLayoutPanelAddProductMain.ResumeLayout(false);
			tableLayoutPanelAddProductMain.PerformLayout();
			tabPageOnlineClients.ResumeLayout(false);
			tableLayoutPanelOnlineClients.ResumeLayout(false);
			tableLayoutPanelOnlineClients.PerformLayout();
			tableLayoutPanelLogIn.ResumeLayout(false);
			tableLayoutPanelLogIn.PerformLayout();
			tableLayoutPanelEnterHostPort.ResumeLayout(false);
			tableLayoutPanelEnterHostPort.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TabControl tabControlMain;
		private TabPage tabPageSignUp;
		private TabPage tabPageSignIn;
		private TabPage tabPageCatalog;
		private TabPage tabPageYourProducts;
		private TabPage tabPageAddProduct;
		private TabPage tabPageOnlineClients;
		private TableLayoutPanel tableLayoutPanelSignUp;
		private TableLayoutPanel tableLayoutPanelSignUpMain;
		private Label labelSignUpEnterName;
		private Label labelSignUpPassword;
		private Label labelSignUpRepeatPassword;
		private Label labelChooseRole;
		private Label labelSignUpButton;
		private TextBox textBoxSignUpPassword;
		private TextBox textBoxSignUpRepeatPassword;
		private TextBox textBoxSignUpName;
		private ComboBox comboBoxChooseRole;
		private TableLayoutPanel tableLayoutPanelSignUpChooseRole;
		private TextBox textBoxSignUpAdminCode;
		private Button buttonSignUp;
		private TableLayoutPanel tableLayoutPanelSignIn;
		private TableLayoutPanel tableLayoutPanelSignInMain;
		private Label labelSignInName;
		private Label labelSignInPassword;
		private TextBox textBoxSignInPassword;
		private TextBox textBoxSignInName;
		private Label labelSignInButton;
		private Button buttonSignIn;
		private TableLayoutPanel tableLayoutPanelLogIn;
		private Label labelWelcomeMesage;
		private Button buttonLogOut;
		private TableLayoutPanel tableLayoutPanelCatalogMain;
		private TableLayoutPanel tableLayoutPanel1;
		private Label labelCatalogBalanceValue;
		private Label labelCatalogBalance;
		private Button buttonCatalogAddMoneyToBalance;
		private ListBox listBoxCatalog;
		private TableLayoutPanel tableLayoutPanelCatalogBuy;
		private Button buttonCatalogBuy;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanelYourProductsRemoveProduct;
		private Button buttonYourProductsRemoveProduct;
		private Label labelYourProductsRemoveProduct;
		private ListBox listBoxYourProducts;
		private TableLayoutPanel tableLayoutPanelAddProduct;
		private TableLayoutPanel tableLayoutPanelAddProductMain;
		private Label labelAddProductName;
		private Label labelAddProductCost;
		private TextBox textBoxAddProductCost;
		private TextBox textBoxAddProductName;
		private Label labelAddProductClickButtton;
		private Button buttonAddProduct;
		private TableLayoutPanel tableLayoutPanelOnlineClients;
		private Label labelOnlineClients;
		private TableLayoutPanel tableLayoutPanelEnterHostPort;
		private Label labelEnterHost;
		private TextBox textBoxEnterPort;
		private Label labelEnterPort;
		private TextBox textBoxEnterHost;
		private Button buttonCatalogRefresh;
		private Button buttonYourProductsRefresh;
		private Button buttonOnlineClientsRefresh;
		private ListBox listBoxOnlineClients;
	}
}
