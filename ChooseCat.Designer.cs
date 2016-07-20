namespace Kotki
{
    partial class ChooseCat
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
            this.components = new System.ComponentModel.Container();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.CatsName = new System.Windows.Forms.ComboBox();
            this.catsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Kotki.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(313, -3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 308);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // CatsName
            // 
            this.CatsName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catsBindingSource, "Name", true));
            this.CatsName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catsBindingSource, "Name", true));
            this.CatsName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.catsBindingSource, "Name", true));
            this.CatsName.DataSource = this.catsBindingSource;
            this.CatsName.DisplayMember = "Name";
            this.CatsName.FormattingEnabled = true;
            this.CatsName.Location = new System.Drawing.Point(12, 68);
            this.CatsName.Name = "CatsName";
            this.CatsName.Size = new System.Drawing.Size(294, 23);
            this.CatsName.TabIndex = 2;
            this.CatsName.ValueMember = "Name";
            this.CatsName.SelectedIndexChanged += new System.EventHandler(this.CatsName_SelectedIndexChanged_1);
            this.CatsName.DataSourceChanged += new System.EventHandler(this.CatsName_DataSourceChanged);
            this.CatsName.BindingContextChanged += new System.EventHandler(this.CatsName_BindingContextChanged);
            this.CatsName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatsName_KeyDown);
            this.CatsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatsName_KeyPress);
            // 
            // catsBindingSource
            // 
            this.catsBindingSource.DataMember = "Cats";
            this.catsBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose your cat from list below to see its data!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(331, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatsName);
            this.Controls.Add(this.vScrollBar1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "ChooseCat";
            this.Text = "Choose Cat!";
            this.Load += new System.EventHandler(this.ChooseCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox CatsName;
        private System.Windows.Forms.BindingSource catsBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label1;
    }
}