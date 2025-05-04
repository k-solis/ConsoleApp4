namespace ConsoleApp4.EmpaquetarProductos
{
    partial class EmpaquetarProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ordenEmpaquetadaBTN = new Button();
            cancelarBTN = new Button();
            listView2 = new ListView();
            skuProductoCLM = new ColumnHeader();
            nombreProductoCLM = new ColumnHeader();
            cantidadProductoCLM = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ordenEmpaquetadaBTN
            // 
            ordenEmpaquetadaBTN.Location = new Point(484, 407);
            ordenEmpaquetadaBTN.Name = "ordenEmpaquetadaBTN";
            ordenEmpaquetadaBTN.Size = new Size(199, 29);
            ordenEmpaquetadaBTN.TabIndex = 17;
            ordenEmpaquetadaBTN.Text = "Orden Empaquetada";
            ordenEmpaquetadaBTN.UseVisualStyleBackColor = true;
            // 
            // cancelarBTN
            // 
            cancelarBTN.Location = new Point(688, 407);
            cancelarBTN.Name = "cancelarBTN";
            cancelarBTN.Size = new Size(94, 29);
            cancelarBTN.TabIndex = 16;
            cancelarBTN.Text = "Cancelar";
            cancelarBTN.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { skuProductoCLM, nombreProductoCLM, cantidadProductoCLM });
            listView2.Enabled = false;
            listView2.HideSelection = true;
            listView2.Location = new Point(12, 76);
            listView2.Name = "listView2";
            listView2.Size = new Size(777, 314);
            listView2.TabIndex = 15;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // skuProductoCLM
            // 
            skuProductoCLM.Text = "SKU Producto";
            skuProductoCLM.Width = 200;
            // 
            // nombreProductoCLM
            // 
            nombreProductoCLM.Text = "Nombre Producto";
            nombreProductoCLM.Width = 200;
            // 
            // cantidadProductoCLM
            // 
            cantidadProductoCLM.Text = "Cantidad";
            cantidadProductoCLM.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 13;
            label2.Text = "Productos a empaquetar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 12;
            label1.Text = "Orden ";
            label1.Click += label1_Click_1;
            // 
            // EmpaquetarProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ordenEmpaquetadaBTN);
            Controls.Add(cancelarBTN);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpaquetarProductosForm";
            Text = "EmpaquetarProductosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ordenEmpaquetadaBTN;
        private Button cancelarBTN;
        private ListView listView2;
        private ColumnHeader skuProductoCLM;
        private ColumnHeader nombreProductoCLM;
        private ColumnHeader cantidadProductoCLM;
        private Label label2;
        private Label label1;
    }
}