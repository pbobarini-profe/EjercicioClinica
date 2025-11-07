namespace EjercicioClinica
{
    partial class FrmDetalleHistoriaClinica
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
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaClinicaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEventoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesHistoriasClinicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicioClinicaDataSet3 = new EjercicioGimnasio.EjercicioClinicaDataSet3();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtHistoriaClinicaId = new System.Windows.Forms.TextBox();
            this.txtMedicoId = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTipoEventoId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbHistoria = new System.Windows.Forms.ComboBox();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.detallesHistoriasClinicasTableAdapter = new EjercicioGimnasio.EjercicioClinicaDataSet3TableAdapters.DetallesHistoriasClinicasTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesHistoriasClinicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioClinicaDataSet3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDetalles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.04663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 683);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.historiaClinicaIdDataGridViewTextBoxColumn,
            this.medicoIdDataGridViewTextBoxColumn,
            this.tipoEventoIdDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvDetalles.DataSource = this.detallesHistoriasClinicasBindingSource;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(3, 74);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(973, 471);
            this.dgvDetalles.TabIndex = 0;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historiaClinicaIdDataGridViewTextBoxColumn
            // 
            this.historiaClinicaIdDataGridViewTextBoxColumn.DataPropertyName = "historiaClinicaId";
            this.historiaClinicaIdDataGridViewTextBoxColumn.HeaderText = "historiaClinicaId";
            this.historiaClinicaIdDataGridViewTextBoxColumn.Name = "historiaClinicaIdDataGridViewTextBoxColumn";
            this.historiaClinicaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicoIdDataGridViewTextBoxColumn
            // 
            this.medicoIdDataGridViewTextBoxColumn.DataPropertyName = "medicoId";
            this.medicoIdDataGridViewTextBoxColumn.HeaderText = "medicoId";
            this.medicoIdDataGridViewTextBoxColumn.Name = "medicoIdDataGridViewTextBoxColumn";
            this.medicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoEventoIdDataGridViewTextBoxColumn
            // 
            this.tipoEventoIdDataGridViewTextBoxColumn.DataPropertyName = "tipoEventoId";
            this.tipoEventoIdDataGridViewTextBoxColumn.HeaderText = "tipoEventoId";
            this.tipoEventoIdDataGridViewTextBoxColumn.Name = "tipoEventoIdDataGridViewTextBoxColumn";
            this.tipoEventoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesHistoriasClinicasBindingSource
            // 
            this.detallesHistoriasClinicasBindingSource.DataMember = "DetallesHistoriasClinicas";
            this.detallesHistoriasClinicasBindingSource.DataSource = this.ejercicioClinicaDataSet3;
            this.detallesHistoriasClinicasBindingSource.CurrentChanged += new System.EventHandler(this.detallesHistoriasClinicasBindingSource_CurrentChanged);
            // 
            // ejercicioClinicaDataSet3
            // 
            this.ejercicioClinicaDataSet3.DataSetName = "EjercicioClinicaDataSet3";
            this.ejercicioClinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 551);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 129);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtHistoriaClinicaId);
            this.flowLayoutPanel2.Controls.Add(this.txtMedicoId);
            this.flowLayoutPanel2.Controls.Add(this.dtpFecha);
            this.flowLayoutPanel2.Controls.Add(this.txtTipoEventoId);
            this.flowLayoutPanel2.Controls.Add(this.txtDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.cbMedico);
            this.flowLayoutPanel2.Controls.Add(this.cbHistoria);
            this.flowLayoutPanel2.Controls.Add(this.cbEvento);
            this.flowLayoutPanel2.Controls.Add(this.btnFiltrar);
            this.flowLayoutPanel2.Controls.Add(this.btnMostrarTodo);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(508, 82);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txtHistoriaClinicaId
            // 
            this.txtHistoriaClinicaId.Location = new System.Drawing.Point(3, 3);
            this.txtHistoriaClinicaId.Name = "txtHistoriaClinicaId";
            this.txtHistoriaClinicaId.Size = new System.Drawing.Size(100, 20);
            this.txtHistoriaClinicaId.TabIndex = 0;
            this.txtHistoriaClinicaId.TextChanged += new System.EventHandler(this.txtHistoriaClinicaId_TextChanged);
            // 
            // txtMedicoId
            // 
            this.txtMedicoId.Location = new System.Drawing.Point(3, 29);
            this.txtMedicoId.Name = "txtMedicoId";
            this.txtMedicoId.Size = new System.Drawing.Size(100, 20);
            this.txtMedicoId.TabIndex = 1;
            this.txtMedicoId.Text = "medicoId";
            this.txtMedicoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedicoId.TextChanged += new System.EventHandler(this.txtMedicoId_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(3, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtTipoEventoId
            // 
            this.txtTipoEventoId.Location = new System.Drawing.Point(109, 3);
            this.txtTipoEventoId.Name = "txtTipoEventoId";
            this.txtTipoEventoId.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEventoId.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cbMedico
            // 
            this.cbMedico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicosBindingSource, "nombre", true));
            this.cbMedico.DataSource = this.medicosBindingSource;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(109, 55);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(121, 21);
            this.cbMedico.TabIndex = 5;
            this.cbMedico.ValueMember = "nombre";
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataSource = typeof(Modelos.Medicos);
            // 
            // cbHistoria
            // 
            this.cbHistoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesHistoriasClinicasBindingSource, "historiaClinicaId", true));
            this.cbHistoria.DataSource = this.ejercicioClinicaDataSet3;
            this.cbHistoria.DisplayMember = "DetallesHistoriasClinicas.historiaClinicaId";
            this.cbHistoria.FormattingEnabled = true;
            this.cbHistoria.Location = new System.Drawing.Point(236, 3);
            this.cbHistoria.Name = "cbHistoria";
            this.cbHistoria.Size = new System.Drawing.Size(121, 21);
            this.cbHistoria.TabIndex = 6;
            this.cbHistoria.ValueMember = "historiaClinicaId";
            this.cbHistoria.SelectedIndexChanged += new System.EventHandler(this.cbHistoria_SelectedIndexChanged);
            // 
            // cbEvento
            // 
            this.cbEvento.DataSource = this.detallesHistoriasClinicasBindingSource;
            this.cbEvento.DisplayMember = "tipoEventoId";
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(236, 30);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(121, 21);
            this.cbEvento.TabIndex = 7;
            this.cbEvento.ValueMember = "tipoEventoId";
            this.cbEvento.SelectedIndexChanged += new System.EventHandler(this.cbEvento_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(363, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(363, 32);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTodo.TabIndex = 9;
            this.btnMostrarTodo.Text = "MostrarTodo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.button6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(970, 33);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "actualizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.FrmDetalleHistoriaClinica_Load_1);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.tbMin);
            this.flowLayoutPanel4.Controls.Add(this.tbMax);
            this.flowLayoutPanel4.Controls.Add(this.button4);
            this.flowLayoutPanel4.Controls.Add(this.button5);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(973, 65);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(3, 3);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 0;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(109, 3);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Filtrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Desfiltrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // detallesHistoriasClinicasTableAdapter
            // 
            this.detallesHistoriasClinicasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDetalleHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDetalleHistoriaClinica";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDetalleHistoriaClinica_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesHistoriasClinicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioClinicaDataSet3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtHistoriaClinicaId;
        private System.Windows.Forms.TextBox txtMedicoId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private EjercicioGimnasio.EjercicioClinicaDataSet3 ejercicioClinicaDataSet3;
        private System.Windows.Forms.BindingSource detallesHistoriasClinicasBindingSource;
        private EjercicioGimnasio.EjercicioClinicaDataSet3TableAdapters.DetallesHistoriasClinicasTableAdapter detallesHistoriasClinicasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtTipoEventoId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiaClinicaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEventoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbHistoria;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.BindingSource medicosBindingSource;
    }
}