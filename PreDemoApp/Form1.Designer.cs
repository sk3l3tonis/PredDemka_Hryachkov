namespace PreDemoApp
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
            flowLayoutPanelProducts = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.Location = new Point(12, 12);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(574, 388);
            flowLayoutPanelProducts.TabIndex = 0;
            flowLayoutPanelProducts.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(12, 406);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(239, 39);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(620, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(620, 199);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 98);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Фильтровать:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(643, 176);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "Сортировать:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 254);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Найти:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanelProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}
