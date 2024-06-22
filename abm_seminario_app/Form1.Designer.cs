namespace abm_seminario_app
{
	partial class form_principal
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_data = new System.Windows.Forms.DataGridView();
			this.btn_newUser = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_deleteUser = new System.Windows.Forms.Button();
			this.btn_updateUser = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.header_panel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
			this.panel1.SuspendLayout();
			this.header_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_data
			// 
			this.dgv_data.AllowUserToAddRows = false;
			this.dgv_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_data.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
			this.dgv_data.Location = new System.Drawing.Point(294, 110);
			this.dgv_data.Name = "dgv_data";
			this.dgv_data.ReadOnly = true;
			this.dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgv_data.RowHeadersVisible = false;
			this.dgv_data.RowHeadersWidth = 62;
			this.dgv_data.RowTemplate.Height = 28;
			this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_data.Size = new System.Drawing.Size(915, 445);
			this.dgv_data.TabIndex = 0;
			this.dgv_data.SelectionChanged += new System.EventHandler(this.row_selectionChanged);
			// 
			// btn_newUser
			// 
			this.btn_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
			this.btn_newUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
			this.btn_newUser.FlatAppearance.BorderSize = 3;
			this.btn_newUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_newUser.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btn_newUser.Location = new System.Drawing.Point(12, 162);
			this.btn_newUser.Name = "btn_newUser";
			this.btn_newUser.Size = new System.Drawing.Size(254, 52);
			this.btn_newUser.TabIndex = 2;
			this.btn_newUser.Text = "Nuevo Usuario";
			this.btn_newUser.UseVisualStyleBackColor = false;
			this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
			this.panel1.Controls.Add(this.btn_updateUser);
			this.panel1.Controls.Add(this.btn_deleteUser);
			this.panel1.Controls.Add(this.btn_newUser);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(296, 555);
			this.panel1.TabIndex = 3;
			// 
			// btn_deleteUser
			// 
			this.btn_deleteUser.BackColor = System.Drawing.Color.Tomato;
			this.btn_deleteUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btn_deleteUser.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btn_deleteUser.Location = new System.Drawing.Point(12, 229);
			this.btn_deleteUser.Name = "btn_deleteUser";
			this.btn_deleteUser.Size = new System.Drawing.Size(254, 51);
			this.btn_deleteUser.TabIndex = 3;
			this.btn_deleteUser.Text = "Eliminar Cliente";
			this.btn_deleteUser.UseVisualStyleBackColor = false;
			this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
			// 
			// btn_updateUser
			// 
			this.btn_updateUser.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_updateUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btn_updateUser.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btn_updateUser.Location = new System.Drawing.Point(12, 286);
			this.btn_updateUser.Name = "btn_updateUser";
			this.btn_updateUser.Size = new System.Drawing.Size(254, 55);
			this.btn_updateUser.TabIndex = 4;
			this.btn_updateUser.Text = "Actualizar Cliente";
			this.btn_updateUser.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(72, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 42);
			this.label1.TabIndex = 4;
			this.label1.Text = "Clients - ABM";
			// 
			// header_panel
			// 
			this.header_panel.BackColor = System.Drawing.Color.IndianRed;
			this.header_panel.Controls.Add(this.label2);
			this.header_panel.Controls.Add(this.label1);
			this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.header_panel.Location = new System.Drawing.Point(296, 0);
			this.header_panel.Name = "header_panel";
			this.header_panel.Size = new System.Drawing.Size(913, 110);
			this.header_panel.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(75, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(392, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Organiza tus clientes de manera rapida y eficiente";
			// 
			// form_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1209, 555);
			this.Controls.Add(this.header_panel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgv_data);
			this.Name = "form_principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.form_principal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
			this.panel1.ResumeLayout(false);
			this.header_panel.ResumeLayout(false);
			this.header_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_data;
		private System.Windows.Forms.Button btn_newUser;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_updateUser;
		private System.Windows.Forms.Button btn_deleteUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel header_panel;
		private System.Windows.Forms.Label label2;
	}
}

