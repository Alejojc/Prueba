
namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.TextoBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(21, 139);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(65, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Excel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(21, 91);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(108, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Navegador";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // TextoBuscar
            // 
            this.TextoBuscar.AllowPromptAsInput = true;
            this.TextoBuscar.AnimateReadOnly = false;
            this.TextoBuscar.AsciiOnly = false;
            this.TextoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextoBuscar.BeepOnError = false;
            this.TextoBuscar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextoBuscar.Depth = 0;
            this.TextoBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextoBuscar.HidePromptOnLeave = false;
            this.TextoBuscar.HideSelection = true;
            this.TextoBuscar.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextoBuscar.LeadingIcon = null;
            this.TextoBuscar.Location = new System.Drawing.Point(136, 79);
            this.TextoBuscar.Mask = "";
            this.TextoBuscar.MaxLength = 32767;
            this.TextoBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.TextoBuscar.Name = "TextoBuscar";
            this.TextoBuscar.PasswordChar = '\0';
            this.TextoBuscar.PrefixSuffixText = null;
            this.TextoBuscar.PromptChar = '_';
            this.TextoBuscar.ReadOnly = false;
            this.TextoBuscar.RejectInputOnFirstFailure = false;
            this.TextoBuscar.ResetOnPrompt = true;
            this.TextoBuscar.ResetOnSpace = true;
            this.TextoBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextoBuscar.SelectedText = "";
            this.TextoBuscar.SelectionLength = 0;
            this.TextoBuscar.SelectionStart = 0;
            this.TextoBuscar.ShortcutsEnabled = true;
            this.TextoBuscar.Size = new System.Drawing.Size(250, 48);
            this.TextoBuscar.SkipLiterals = true;
            this.TextoBuscar.TabIndex = 2;
            this.TextoBuscar.TabStop = false;
            this.TextoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextoBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextoBuscar.TrailingIcon = null;
            this.TextoBuscar.UseSystemPasswordChar = false;
            this.TextoBuscar.ValidatingType = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 232);
            this.Controls.Add(this.TextoBuscar);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextoBuscar;
    }
}

