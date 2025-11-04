
namespace EjercicioClinica
{
    partial class PActividadesClientes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtoActividadesClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHistoriasClinicas = new System.Windows.Forms.ComboBox();
            this.historiasClinicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbActividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVigente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.actividadesClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoActividadesClientesBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiasClinicasBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.04663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1273, 458);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn,
            this.dniPacienteDataGridViewTextBoxColumn,
            this.nombreCompletoPacienteDataGridViewTextBoxColumn,
            this.descripcionActividadDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.estadoVigenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtoActividadesClientesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // numeroHistoriaClinicaDataGridViewTextBoxColumn
            // 
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.DataPropertyName = "numeroHistoriaClinica";
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.HeaderText = "Historia Clinica";
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.Name = "numeroHistoriaClinicaDataGridViewTextBoxColumn";
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroHistoriaClinicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniPacienteDataGridViewTextBoxColumn
            // 
            this.dniPacienteDataGridViewTextBoxColumn.DataPropertyName = "DniPaciente";
            this.dniPacienteDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniPacienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniPacienteDataGridViewTextBoxColumn.Name = "dniPacienteDataGridViewTextBoxColumn";
            this.dniPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniPacienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCompletoPacienteDataGridViewTextBoxColumn
            // 
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCompletoPaciente";
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente";
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.Name = "nombreCompletoPacienteDataGridViewTextBoxColumn";
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoPacienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionActividadDataGridViewTextBoxColumn
            // 
            this.descripcionActividadDataGridViewTextBoxColumn.DataPropertyName = "DescripcionActividad";
            this.descripcionActividadDataGridViewTextBoxColumn.HeaderText = "Actividad";
            this.descripcionActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionActividadDataGridViewTextBoxColumn.Name = "descripcionActividadDataGridViewTextBoxColumn";
            this.descripcionActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoVigenciaDataGridViewTextBoxColumn
            // 
            this.estadoVigenciaDataGridViewTextBoxColumn.DataPropertyName = "EstadoVigencia";
            this.estadoVigenciaDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoVigenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoVigenciaDataGridViewTextBoxColumn.Name = "estadoVigenciaDataGridViewTextBoxColumn";
            this.estadoVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoVigenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtoActividadesClientesBindingSource
            // 
            this.dtoActividadesClientesBindingSource.DataSource = typeof(Modelos.DtoActividadesClientes);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 296);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1245, 158);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.cbHistoriasClinicas);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cbVigente);
            this.flowLayoutPanel2.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.tbDni);
            this.flowLayoutPanel2.Controls.Add(this.tbActividad);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1241, 75);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 43);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccione Historia Clinica:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHistoriasClinicas
            // 
            this.cbHistoriasClinicas.DataSource = this.historiasClinicasBindingSource;
            this.cbHistoriasClinicas.DisplayMember = "id";
            this.cbHistoriasClinicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHistoriasClinicas.FormattingEnabled = true;
            this.cbHistoriasClinicas.Location = new System.Drawing.Point(3, 46);
            this.cbHistoriasClinicas.Name = "cbHistoriasClinicas";
            this.cbHistoriasClinicas.Size = new System.Drawing.Size(121, 24);
            this.cbHistoriasClinicas.TabIndex = 15;
            this.cbHistoriasClinicas.UseWaitCursor = true;
            this.cbHistoriasClinicas.ValueMember = "id";
            this.cbHistoriasClinicas.SelectedIndexChanged += new System.EventHandler(this.cbHistoriasClinicas_SelectedIndexChanged);
            // 
            // historiasClinicasBindingSource
            // 
            this.historiasClinicasBindingSource.DataSource = typeof(Modelos.HistoriasClinicas);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(386, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dni Paciente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(386, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actividad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(493, 3);
            this.tbDni.Name = "tbDni";
            this.tbDni.ReadOnly = true;
            this.tbDni.Size = new System.Drawing.Size(149, 22);
            this.tbDni.TabIndex = 16;
            // 
            // tbActividad
            // 
            this.tbActividad.Location = new System.Drawing.Point(493, 31);
            this.tbActividad.Name = "tbActividad";
            this.tbActividad.ReadOnly = true;
            this.tbActividad.Size = new System.Drawing.Size(656, 22);
            this.tbActividad.TabIndex = 17;
            this.tbActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(141, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vigencia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(141, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Inicio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbVigente
            // 
            this.cbVigente.FormattingEnabled = true;
            this.cbVigente.Items.AddRange(new object[] {
            "Vigente",
            "Cauducado"});
            this.cbVigente.Location = new System.Drawing.Point(247, 3);
            this.cbVigente.Name = "cbVigente";
            this.cbVigente.Size = new System.Drawing.Size(133, 24);
            this.cbVigente.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 87);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1241, 45);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reporte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1245, 29);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // actividadesClientesBindingSource
            // 
            this.actividadesClientesBindingSource.DataSource = typeof(Modelos.ActividadesClientes);
            // 
            // PActividadesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PActividadesClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PActividadesClientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoActividadesClientesBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiasClinicasBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.BindingSource actividadesClientesBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHistoriasClinicas;
        private System.Windows.Forms.BindingSource historiasClinicasBindingSource;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbActividad;
        private System.Windows.Forms.ComboBox cbVigente;
        private System.Windows.Forms.BindingSource dtoActividadesClientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHistoriaClinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}

