namespace PreDemoApp
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureOfProduct = new PictureBox();
            labelProductType = new Label();
            label2 = new Label();
            labelProductName = new Label();
            labelProductArtc = new Label();
            label5 = new Label();
            labelProductCost = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureOfProduct
            // 
            pictureOfProduct.Location = new Point(13, 26);
            pictureOfProduct.Name = "pictureOfProduct";
            pictureOfProduct.Size = new Size(117, 113);
            pictureOfProduct.TabIndex = 0;
            pictureOfProduct.TabStop = false;
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Location = new Point(167, 26);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(102, 20);
            labelProductType.TabIndex = 1;
            labelProductType.Text = "Тип продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 26);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 2;
            label2.Text = "||";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(298, 26);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(106, 20);
            labelProductName.TabIndex = 3;
            labelProductName.Text = "Имя продукта";
            // 
            // labelProductArtc
            // 
            labelProductArtc.AutoSize = true;
            labelProductArtc.Location = new Point(164, 59);
            labelProductArtc.Name = "labelProductArtc";
            labelProductArtc.Size = new Size(69, 20);
            labelProductArtc.TabIndex = 4;
            labelProductArtc.Text = " Артикул";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 103);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 5;
            label5.Text = "Материалы";
            // 
            // labelProductCost
            // 
            labelProductCost.AutoSize = true;
            labelProductCost.Location = new Point(531, 26);
            labelProductCost.Name = "labelProductCost";
            labelProductCost.Size = new Size(45, 20);
            labelProductCost.TabIndex = 6;
            labelProductCost.Text = "Цена";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelProductCost);
            Controls.Add(label5);
            Controls.Add(labelProductArtc);
            Controls.Add(labelProductName);
            Controls.Add(label2);
            Controls.Add(labelProductType);
            Controls.Add(pictureOfProduct);
            Name = "UserControl1";
            Size = new Size(643, 164);
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label labelProductType;
        public Label label2;
        public Label labelProductName;
        public Label labelProductArtc;
        public Label label5;
        public Label labelProductCost;
        public PictureBox pictureOfProduct;
    }
}
