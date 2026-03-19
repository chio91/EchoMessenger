namespace EchoMessenger
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
            label1 = new Label();
            InputTxt = new TextBox();
            ListMsg = new ListBox();
            SendBut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(488, 82);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // InputTxt
            // 
            InputTxt.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            InputTxt.Location = new Point(37, 648);
            InputTxt.Name = "InputTxt";
            InputTxt.Size = new Size(607, 45);
            InputTxt.TabIndex = 1;
            // 
            // ListMsg
            // 
            ListMsg.FormattingEnabled = true;
            ListMsg.Location = new Point(37, 111);
            ListMsg.Name = "ListMsg";
            ListMsg.Size = new Size(974, 484);
            ListMsg.TabIndex = 2;
            // 
            // SendBut
            // 
            SendBut.BackColor = Color.Cornsilk;
            SendBut.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SendBut.ForeColor = Color.CornflowerBlue;
            SendBut.Location = new Point(679, 624);
            SendBut.Name = "SendBut";
            SendBut.Size = new Size(332, 97);
            SendBut.TabIndex = 3;
            SendBut.Text = "전송";
            SendBut.UseVisualStyleBackColor = false;
            SendBut.Click += SendBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 737);
            Controls.Add(SendBut);
            Controls.Add(ListMsg);
            Controls.Add(InputTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InputTxt;
        private ListBox ListMsg;
        private Button SendBut;
    }
}
