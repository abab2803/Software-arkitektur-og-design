namespace GUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_GetVolt = new System.Windows.Forms.TextBox();
            this.txtBoxComport = new System.Windows.Forms.TextBox();
            this.txtBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.txtBox_SetVolt = new System.Windows.Forms.TextBox();
            this.btn_Remote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Current = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtSubscibe = new System.Windows.Forms.TextBox();
            this.txtPubText = new System.Windows.Forms.TextBox();
            this.txtSubscription = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "GetVolt: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SerialNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SetVolt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "SelectComport:";
            // 
            // txtBox_GetVolt
            // 
            this.txtBox_GetVolt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_GetVolt.Location = new System.Drawing.Point(134, 53);
            this.txtBox_GetVolt.Name = "txtBox_GetVolt";
            this.txtBox_GetVolt.Size = new System.Drawing.Size(125, 20);
            this.txtBox_GetVolt.TabIndex = 6;
            // 
            // txtBoxComport
            // 
            this.txtBoxComport.Location = new System.Drawing.Point(134, 121);
            this.txtBoxComport.Name = "txtBoxComport";
            this.txtBoxComport.Size = new System.Drawing.Size(125, 27);
            this.txtBoxComport.TabIndex = 7;
            // 
            // txtBox_SerialNumber
            // 
            this.txtBox_SerialNumber.Location = new System.Drawing.Point(134, 21);
            this.txtBox_SerialNumber.Name = "txtBox_SerialNumber";
            this.txtBox_SerialNumber.Size = new System.Drawing.Size(125, 27);
            this.txtBox_SerialNumber.TabIndex = 8;
            // 
            // txtBox_SetVolt
            // 
            this.txtBox_SetVolt.Location = new System.Drawing.Point(265, 228);
            this.txtBox_SetVolt.Name = "txtBox_SetVolt";
            this.txtBox_SetVolt.Size = new System.Drawing.Size(125, 27);
            this.txtBox_SetVolt.TabIndex = 9;
            // 
            // btn_Remote
            // 
            this.btn_Remote.Location = new System.Drawing.Point(433, 179);
            this.btn_Remote.Name = "btn_Remote";
            this.btn_Remote.Size = new System.Drawing.Size(94, 29);
            this.btn_Remote.TabIndex = 10;
            this.btn_Remote.Text = "Remote";
            this.btn_Remote.UseVisualStyleBackColor = true;
            this.btn_Remote.Click += new System.EventHandler(this.btn_Remote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current:";
            // 
            // txtBox_Current
            // 
            this.txtBox_Current.Location = new System.Drawing.Point(134, 83);
            this.txtBox_Current.Name = "txtBox_Current";
            this.txtBox_Current.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Current.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Server:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "PSU ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Topic To Pub:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(265, 269);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(125, 27);
            this.txtConnectionString.TabIndex = 16;
            // 
            // txtSubscibe
            // 
            this.txtSubscibe.Location = new System.Drawing.Point(265, 313);
            this.txtSubscibe.Name = "txtSubscibe";
            this.txtSubscibe.Size = new System.Drawing.Size(125, 27);
            this.txtSubscibe.TabIndex = 17;
            // 
            // txtPubText
            // 
            this.txtPubText.Location = new System.Drawing.Point(265, 352);
            this.txtPubText.Name = "txtPubText";
            this.txtPubText.Size = new System.Drawing.Size(125, 27);
            this.txtPubText.TabIndex = 18;
            // 
            // txtSubscription
            // 
            this.txtSubscription.Location = new System.Drawing.Point(185, 398);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(190, 27);
            this.txtSubscription.TabIndex = 19;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(433, 267);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(433, 311);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(94, 29);
            this.btnSubscribe.TabIndex = 21;
            this.btnSubscribe.Text = "Subscrib";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(433, 350);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(94, 29);
            this.btnPublish.TabIndex = 22;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSubscription);
            this.Controls.Add(this.txtPubText);
            this.Controls.Add(this.txtSubscibe);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Current);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Remote);
            this.Controls.Add(this.txtBox_SetVolt);
            this.Controls.Add(this.txtBox_SerialNumber);
            this.Controls.Add(this.txtBoxComport);
            this.Controls.Add(this.txtBox_GetVolt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox_GetVolt;
        private TextBox txtBoxComport;
        private TextBox txtBox_SerialNumber;
        private TextBox txtBox_SetVolt;
        private Button btn_Remote;
        private Label label5;
        private TextBox txtBox_Current;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtConnectionString;
        private TextBox txtSubscibe;
        private TextBox txtPubText;
        private TextBox txtSubscription;
        private Button btnConnect;
        private Button btnSubscribe;
        private Button btnPublish;
    }
}