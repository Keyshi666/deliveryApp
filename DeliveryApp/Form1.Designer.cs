namespace DeliveryApp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_submit = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.dropdown_destination = new System.Windows.Forms.ComboBox();
            this.label_product = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label_destination = new System.Windows.Forms.Label();
            this.dropdownDelivery = new System.Windows.Forms.ComboBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(52, 136);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(298, 33);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Рассчитать стоимость доставки";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(205, 179);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(145, 20);
            this.result.TabIndex = 1;
            // 
            // dropdown_destination
            // 
            this.dropdown_destination.FormattingEnabled = true;
            this.dropdown_destination.Items.AddRange(new object[] {
            "Столичный город",
            "Обычный город",
            "Районный населенный пункт"});
            this.dropdown_destination.Location = new System.Drawing.Point(205, 109);
            this.dropdown_destination.Name = "dropdown_destination";
            this.dropdown_destination.Size = new System.Drawing.Size(145, 21);
            this.dropdown_destination.TabIndex = 2;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(49, 33);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(127, 13);
            this.label_product.TabIndex = 3;
            this.label_product.Text = "Выберите тип доставки";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(49, 60);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(144, 13);
            this.label_weight.TabIndex = 5;
            this.label_weight.Text = "Введите вес (для тяжелых)";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Enabled = false;
            this.textBox_weight.Location = new System.Drawing.Point(205, 57);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(145, 20);
            this.textBox_weight.TabIndex = 4;
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(49, 112);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(150, 13);
            this.label_destination.TabIndex = 6;
            this.label_destination.Text = "Выберите пункт назначения";
            // 
            // dropdownDelivery
            // 
            this.dropdownDelivery.FormattingEnabled = true;
            this.dropdownDelivery.Items.AddRange(new object[] {
            "Легкий продукт",
            "Тяжелый продукт",
            "Экстренная доставка"});
            this.dropdownDelivery.Location = new System.Drawing.Point(205, 30);
            this.dropdownDelivery.Name = "dropdownDelivery";
            this.dropdownDelivery.Size = new System.Drawing.Size(145, 21);
            this.dropdownDelivery.TabIndex = 7;
            this.dropdownDelivery.SelectedIndexChanged += new System.EventHandler(this.dropdownDelivery_SelectedIndexChanged);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(49, 182);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(62, 13);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "Результат:";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(49, 86);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(124, 13);
            this.label_cost.TabIndex = 10;
            this.label_cost.Text = "Введите цену продукта";
            // 
            // textBox_cost
            // 
            this.textBox_cost.HideSelection = false;
            this.textBox_cost.Location = new System.Drawing.Point(205, 83);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(145, 20);
            this.textBox_cost.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 226);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.dropdownDelivery);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dropdown_destination);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button_submit);
            this.Name = "Form1";
            this.Text = "Расчет стоимости доставки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox dropdown_destination;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.ComboBox dropdownDelivery;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_cost;
    }
}

