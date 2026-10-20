namespace MetatraderLauncher.Views;

partial class LauncherView
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
        groupBox1 = new GroupBox();
        t1_Status = new Label();
        label16 = new Label();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        txt_t1_Balance = new TextBox();
        txt_t1_Currency = new TextBox();
        txt_t1_Login = new TextBox();
        txt_t1_Server = new TextBox();
        label20 = new Label();
        label19 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        groupBox2 = new GroupBox();
        t2_Status = new Label();
        label17 = new Label();
        textBox4 = new TextBox();
        textBox3 = new TextBox();
        txt_t2_Balance = new TextBox();
        txt_t2_Currency = new TextBox();
        txt_t2_Login = new TextBox();
        txt_t2_Server = new TextBox();
        label22 = new Label();
        label21 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        groupBox3 = new GroupBox();
        t3_Status = new Label();
        label18 = new Label();
        textBox6 = new TextBox();
        textBox5 = new TextBox();
        txt_t3_Balance = new TextBox();
        txt_t3_Currency = new TextBox();
        txt_t3_Login = new TextBox();
        txt_t3_Server = new TextBox();
        label24 = new Label();
        label23 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        groupBox4 = new GroupBox();
        btn_t1_Kill = new Button();
        btn_t1_Connect = new Button();
        groupBox5 = new GroupBox();
        btn_t2_Kill = new Button();
        btn_t2_Connect = new Button();
        groupBox6 = new GroupBox();
        btn_t3_Kill = new Button();
        btn_t3_Connect = new Button();
        groupBox7 = new GroupBox();
        btn_LaunchAll = new Button();
        btn_KillAll = new Button();
        ckbx_Connect = new CheckBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox7.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(t1_Status);
        groupBox1.Controls.Add(label16);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(txt_t1_Balance);
        groupBox1.Controls.Add(txt_t1_Currency);
        groupBox1.Controls.Add(txt_t1_Login);
        groupBox1.Controls.Add(txt_t1_Server);
        groupBox1.Controls.Add(label20);
        groupBox1.Controls.Add(label19);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Location = new Point(25, 19);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(209, 236);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Terminal 1";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // t1_Status
        // 
        t1_Status.AutoSize = true;
        t1_Status.Location = new Point(68, 205);
        t1_Status.Name = "t1_Status";
        t1_Status.Size = new Size(58, 15);
        t1_Status.TabIndex = 3;
        t1_Status.Text = "Unknown";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(10, 205);
        label16.Name = "label16";
        label16.Size = new Size(42, 15);
        label16.TabIndex = 2;
        label16.Text = "Status:";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(75, 167);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(127, 23);
        textBox2.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(75, 138);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(127, 23);
        textBox1.TabIndex = 1;
        // 
        // txt_t1_Balance
        // 
        txt_t1_Balance.Location = new Point(75, 110);
        txt_t1_Balance.Name = "txt_t1_Balance";
        txt_t1_Balance.ReadOnly = true;
        txt_t1_Balance.Size = new Size(127, 23);
        txt_t1_Balance.TabIndex = 1;
        // 
        // txt_t1_Currency
        // 
        txt_t1_Currency.Location = new Point(75, 82);
        txt_t1_Currency.Name = "txt_t1_Currency";
        txt_t1_Currency.ReadOnly = true;
        txt_t1_Currency.Size = new Size(127, 23);
        txt_t1_Currency.TabIndex = 1;
        // 
        // txt_t1_Login
        // 
        txt_t1_Login.Location = new Point(66, 55);
        txt_t1_Login.Name = "txt_t1_Login";
        txt_t1_Login.ReadOnly = true;
        txt_t1_Login.Size = new Size(136, 23);
        txt_t1_Login.TabIndex = 1;
        // 
        // txt_t1_Server
        // 
        txt_t1_Server.Location = new Point(66, 28);
        txt_t1_Server.Name = "txt_t1_Server";
        txt_t1_Server.ReadOnly = true;
        txt_t1_Server.Size = new Size(136, 23);
        txt_t1_Server.TabIndex = 1;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(12, 171);
        label20.Name = "label20";
        label20.Size = new Size(39, 15);
        label20.TabIndex = 0;
        label20.Text = "Profit:";
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(12, 142);
        label19.Name = "label19";
        label19.Size = new Size(43, 15);
        label19.TabIndex = 0;
        label19.Text = "Equity:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 114);
        label5.Name = "label5";
        label5.Size = new Size(51, 15);
        label5.TabIndex = 0;
        label5.Text = "Balance:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 86);
        label4.Name = "label4";
        label4.Size = new Size(58, 15);
        label4.TabIndex = 0;
        label4.Text = "Currency:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 58);
        label3.Name = "label3";
        label3.Size = new Size(40, 15);
        label3.TabIndex = 0;
        label3.Text = "Login:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 32);
        label2.Name = "label2";
        label2.Size = new Size(42, 15);
        label2.TabIndex = 0;
        label2.Text = "Server:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(t2_Status);
        groupBox2.Controls.Add(label17);
        groupBox2.Controls.Add(textBox4);
        groupBox2.Controls.Add(textBox3);
        groupBox2.Controls.Add(txt_t2_Balance);
        groupBox2.Controls.Add(txt_t2_Currency);
        groupBox2.Controls.Add(txt_t2_Login);
        groupBox2.Controls.Add(txt_t2_Server);
        groupBox2.Controls.Add(label22);
        groupBox2.Controls.Add(label21);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label9);
        groupBox2.Location = new Point(258, 19);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(209, 236);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "Terminal 2";
        // 
        // t2_Status
        // 
        t2_Status.AutoSize = true;
        t2_Status.Location = new Point(68, 205);
        t2_Status.Name = "t2_Status";
        t2_Status.Size = new Size(58, 15);
        t2_Status.TabIndex = 3;
        t2_Status.Text = "Unknown";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(8, 205);
        label17.Name = "label17";
        label17.Size = new Size(42, 15);
        label17.TabIndex = 2;
        label17.Text = "Status:";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(73, 166);
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(127, 23);
        textBox4.TabIndex = 1;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(73, 138);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new Size(127, 23);
        textBox3.TabIndex = 1;
        // 
        // txt_t2_Balance
        // 
        txt_t2_Balance.Location = new Point(73, 110);
        txt_t2_Balance.Name = "txt_t2_Balance";
        txt_t2_Balance.ReadOnly = true;
        txt_t2_Balance.Size = new Size(127, 23);
        txt_t2_Balance.TabIndex = 1;
        // 
        // txt_t2_Currency
        // 
        txt_t2_Currency.Location = new Point(73, 82);
        txt_t2_Currency.Name = "txt_t2_Currency";
        txt_t2_Currency.ReadOnly = true;
        txt_t2_Currency.Size = new Size(127, 23);
        txt_t2_Currency.TabIndex = 1;
        // 
        // txt_t2_Login
        // 
        txt_t2_Login.Location = new Point(65, 55);
        txt_t2_Login.Name = "txt_t2_Login";
        txt_t2_Login.ReadOnly = true;
        txt_t2_Login.Size = new Size(135, 23);
        txt_t2_Login.TabIndex = 1;
        // 
        // txt_t2_Server
        // 
        txt_t2_Server.Location = new Point(65, 28);
        txt_t2_Server.Name = "txt_t2_Server";
        txt_t2_Server.ReadOnly = true;
        txt_t2_Server.Size = new Size(135, 23);
        txt_t2_Server.TabIndex = 1;
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(10, 170);
        label22.Name = "label22";
        label22.Size = new Size(39, 15);
        label22.TabIndex = 0;
        label22.Text = "Profit:";
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(10, 142);
        label21.Name = "label21";
        label21.Size = new Size(43, 15);
        label21.TabIndex = 0;
        label21.Text = "Equity:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(10, 114);
        label6.Name = "label6";
        label6.Size = new Size(51, 15);
        label6.TabIndex = 0;
        label6.Text = "Balance:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(10, 86);
        label7.Name = "label7";
        label7.Size = new Size(58, 15);
        label7.TabIndex = 0;
        label7.Text = "Currency:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(10, 58);
        label8.Name = "label8";
        label8.Size = new Size(40, 15);
        label8.TabIndex = 0;
        label8.Text = "Login:";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(10, 32);
        label9.Name = "label9";
        label9.Size = new Size(42, 15);
        label9.TabIndex = 0;
        label9.Text = "Server:";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(t3_Status);
        groupBox3.Controls.Add(label18);
        groupBox3.Controls.Add(textBox6);
        groupBox3.Controls.Add(textBox5);
        groupBox3.Controls.Add(txt_t3_Balance);
        groupBox3.Controls.Add(txt_t3_Currency);
        groupBox3.Controls.Add(txt_t3_Login);
        groupBox3.Controls.Add(txt_t3_Server);
        groupBox3.Controls.Add(label24);
        groupBox3.Controls.Add(label23);
        groupBox3.Controls.Add(label11);
        groupBox3.Controls.Add(label12);
        groupBox3.Controls.Add(label13);
        groupBox3.Controls.Add(label14);
        groupBox3.Location = new Point(491, 19);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(209, 236);
        groupBox3.TabIndex = 0;
        groupBox3.TabStop = false;
        groupBox3.Text = "Terminal 3";
        // 
        // t3_Status
        // 
        t3_Status.AutoSize = true;
        t3_Status.Location = new Point(71, 205);
        t3_Status.Name = "t3_Status";
        t3_Status.Size = new Size(58, 15);
        t3_Status.TabIndex = 3;
        t3_Status.Text = "Unknown";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(10, 205);
        label18.Name = "label18";
        label18.Size = new Size(42, 15);
        label18.TabIndex = 2;
        label18.Text = "Status:";
        // 
        // textBox6
        // 
        textBox6.Location = new Point(73, 167);
        textBox6.Name = "textBox6";
        textBox6.ReadOnly = true;
        textBox6.Size = new Size(127, 23);
        textBox6.TabIndex = 1;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(73, 138);
        textBox5.Name = "textBox5";
        textBox5.ReadOnly = true;
        textBox5.Size = new Size(127, 23);
        textBox5.TabIndex = 1;
        // 
        // txt_t3_Balance
        // 
        txt_t3_Balance.Location = new Point(73, 110);
        txt_t3_Balance.Name = "txt_t3_Balance";
        txt_t3_Balance.ReadOnly = true;
        txt_t3_Balance.Size = new Size(127, 23);
        txt_t3_Balance.TabIndex = 1;
        // 
        // txt_t3_Currency
        // 
        txt_t3_Currency.Location = new Point(73, 82);
        txt_t3_Currency.Name = "txt_t3_Currency";
        txt_t3_Currency.ReadOnly = true;
        txt_t3_Currency.Size = new Size(127, 23);
        txt_t3_Currency.TabIndex = 1;
        // 
        // txt_t3_Login
        // 
        txt_t3_Login.Location = new Point(64, 55);
        txt_t3_Login.Name = "txt_t3_Login";
        txt_t3_Login.ReadOnly = true;
        txt_t3_Login.Size = new Size(136, 23);
        txt_t3_Login.TabIndex = 1;
        // 
        // txt_t3_Server
        // 
        txt_t3_Server.Location = new Point(64, 28);
        txt_t3_Server.Name = "txt_t3_Server";
        txt_t3_Server.ReadOnly = true;
        txt_t3_Server.Size = new Size(136, 23);
        txt_t3_Server.TabIndex = 1;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(10, 171);
        label24.Name = "label24";
        label24.Size = new Size(39, 15);
        label24.TabIndex = 0;
        label24.Text = "Profit:";
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(10, 142);
        label23.Name = "label23";
        label23.Size = new Size(43, 15);
        label23.TabIndex = 0;
        label23.Text = "Equity:";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(10, 114);
        label11.Name = "label11";
        label11.Size = new Size(51, 15);
        label11.TabIndex = 0;
        label11.Text = "Balance:";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(10, 86);
        label12.Name = "label12";
        label12.Size = new Size(58, 15);
        label12.TabIndex = 0;
        label12.Text = "Currency:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(10, 58);
        label13.Name = "label13";
        label13.Size = new Size(40, 15);
        label13.TabIndex = 0;
        label13.Text = "Login:";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(10, 32);
        label14.Name = "label14";
        label14.Size = new Size(42, 15);
        label14.TabIndex = 0;
        label14.Text = "Server:";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btn_t1_Kill);
        groupBox4.Controls.Add(btn_t1_Connect);
        groupBox4.Location = new Point(25, 276);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(214, 78);
        groupBox4.TabIndex = 1;
        groupBox4.TabStop = false;
        groupBox4.Text = "Terminal 1 Control";
        // 
        // btn_t1_Kill
        // 
        btn_t1_Kill.Location = new Point(114, 28);
        btn_t1_Kill.Name = "btn_t1_Kill";
        btn_t1_Kill.Size = new Size(81, 32);
        btn_t1_Kill.TabIndex = 0;
        btn_t1_Kill.Text = "Trade";
        btn_t1_Kill.UseVisualStyleBackColor = true;
        // 
        // btn_t1_Connect
        // 
        btn_t1_Connect.Location = new Point(12, 28);
        btn_t1_Connect.Name = "btn_t1_Connect";
        btn_t1_Connect.Size = new Size(81, 32);
        btn_t1_Connect.TabIndex = 0;
        btn_t1_Connect.Text = "Connect";
        btn_t1_Connect.UseVisualStyleBackColor = true;
        btn_t1_Connect.Click += btn_t1_Connect_Click;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(btn_t2_Kill);
        groupBox5.Controls.Add(btn_t2_Connect);
        groupBox5.Location = new Point(256, 276);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(214, 78);
        groupBox5.TabIndex = 1;
        groupBox5.TabStop = false;
        groupBox5.Text = "Terminal 2 Control";
        // 
        // btn_t2_Kill
        // 
        btn_t2_Kill.Location = new Point(114, 28);
        btn_t2_Kill.Name = "btn_t2_Kill";
        btn_t2_Kill.Size = new Size(81, 32);
        btn_t2_Kill.TabIndex = 0;
        btn_t2_Kill.Text = "Trade";
        btn_t2_Kill.UseVisualStyleBackColor = true;
        // 
        // btn_t2_Connect
        // 
        btn_t2_Connect.Location = new Point(12, 28);
        btn_t2_Connect.Name = "btn_t2_Connect";
        btn_t2_Connect.Size = new Size(81, 32);
        btn_t2_Connect.TabIndex = 0;
        btn_t2_Connect.Text = "Connect";
        btn_t2_Connect.UseVisualStyleBackColor = true;
        btn_t2_Connect.Click += btn_t2_Connect_Click;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btn_t3_Kill);
        groupBox6.Controls.Add(btn_t3_Connect);
        groupBox6.Location = new Point(489, 276);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(214, 78);
        groupBox6.TabIndex = 1;
        groupBox6.TabStop = false;
        groupBox6.Text = "Terminal 3 Control";
        // 
        // btn_t3_Kill
        // 
        btn_t3_Kill.Location = new Point(114, 28);
        btn_t3_Kill.Name = "btn_t3_Kill";
        btn_t3_Kill.Size = new Size(81, 32);
        btn_t3_Kill.TabIndex = 0;
        btn_t3_Kill.Text = "Trade";
        btn_t3_Kill.UseVisualStyleBackColor = true;
        // 
        // btn_t3_Connect
        // 
        btn_t3_Connect.Location = new Point(12, 28);
        btn_t3_Connect.Name = "btn_t3_Connect";
        btn_t3_Connect.Size = new Size(81, 32);
        btn_t3_Connect.TabIndex = 0;
        btn_t3_Connect.Text = "Connect";
        btn_t3_Connect.UseVisualStyleBackColor = true;
        btn_t3_Connect.Click += btn_t3_Connect_Click;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(btn_LaunchAll);
        groupBox7.Controls.Add(btn_KillAll);
        groupBox7.Location = new Point(24, 372);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(677, 68);
        groupBox7.TabIndex = 2;
        groupBox7.TabStop = false;
        groupBox7.Text = "All Terminals";
        // 
        // btn_LaunchAll
        // 
        btn_LaunchAll.Location = new Point(11, 23);
        btn_LaunchAll.Name = "btn_LaunchAll";
        btn_LaunchAll.Size = new Size(298, 32);
        btn_LaunchAll.TabIndex = 0;
        btn_LaunchAll.Text = "Launch All";
        btn_LaunchAll.UseVisualStyleBackColor = true;
        btn_LaunchAll.Click += btn_LaunchAll_Click;
        // 
        // btn_KillAll
        // 
        btn_KillAll.Location = new Point(366, 23);
        btn_KillAll.Name = "btn_KillAll";
        btn_KillAll.Size = new Size(298, 32);
        btn_KillAll.TabIndex = 0;
        btn_KillAll.Text = "Kill All";
        btn_KillAll.UseVisualStyleBackColor = true;
        btn_KillAll.Click += btn_KillAll_Click;
        // 
        // ckbx_Connect
        // 
        ckbx_Connect.AutoSize = true;
        ckbx_Connect.Location = new Point(24, 456);
        ckbx_Connect.Name = "ckbx_Connect";
        ckbx_Connect.Size = new Size(193, 19);
        ckbx_Connect.TabIndex = 3;
        ckbx_Connect.Text = "Connect to terminals on launch";
        ckbx_Connect.UseVisualStyleBackColor = true;
        // 
        // LauncherView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(724, 487);
        Controls.Add(ckbx_Connect);
        Controls.Add(groupBox7);
        Controls.Add(groupBox6);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LauncherView";
        Text = "MetaTrader Launcher";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        groupBox6.ResumeLayout(false);
        groupBox7.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox groupBox1;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private TextBox txt_t1_Balance;
    private TextBox txt_t1_Currency;
    private TextBox txt_t1_Login;
    private TextBox txt_t1_Server;
    private GroupBox groupBox2;
    private TextBox txt_t2_Balance;
    private TextBox txt_t2_Currency;
    private TextBox txt_t2_Login;
    private TextBox txt_t2_Server;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private GroupBox groupBox3;
    private TextBox txt_t3_Balance;
    private TextBox txt_t3_Currency;
    private TextBox txt_t3_Login;
    private TextBox txt_t3_Server;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private GroupBox groupBox4;
    private Button btn_t1_Kill;
    private Button btn_t1_Connect;
    private GroupBox groupBox5;
    private Button btn_t2_Kill;
    private Button btn_t2_Connect;
    private GroupBox groupBox6;
    private Button btn_t3_Kill;
    private Button btn_t3_Connect;
    private GroupBox groupBox7;
    private Button btn_LaunchAll;
    private Button btn_KillAll;
    private Label label16;
    private Label t1_Status;
    private Label label17;
    private Label t3_Status;
    private Label label18;
    private Label t2_Status;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label20;
    private Label label19;
    private TextBox textBox4;
    private TextBox textBox3;
    private Label label22;
    private Label label21;
    private TextBox textBox6;
    private TextBox textBox5;
    private Label label24;
    private Label label23;
    private CheckBox ckbx_Connect;
}
