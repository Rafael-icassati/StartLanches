using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Http;
using System.Diagnostics;

namespace StartLanches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
            preenchegrid();

            nud_alface.Value = 0;
            nud_bacon.Value = 1;
            nud_hamb_carne.Value = 1;
            nud_ovo.Value = 0;
            nud_queijo.Value = 1;
            calculalanches();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbx_lanches.Text.Equals("X-Bacon"))
            {
                nud_alface.Value = 0;
                nud_bacon.Value = 1;
                nud_hamb_carne.Value = 1;
                nud_ovo.Value = 0;
                nud_queijo.Value = 1;
                calculalanches();

            }
            if (cbx_lanches.Text.Equals("X-Burger"))
            {
                nud_alface.Value = 0;
                nud_bacon.Value = 0;
                nud_hamb_carne.Value = 1;
                nud_ovo.Value = 0;
                nud_queijo.Value = 1;
                calculalanches();
            }
            if (cbx_lanches.Text.Equals("X-Egg"))
            {
                nud_alface.Value = 0;
                nud_bacon.Value = 0;
                nud_hamb_carne.Value = 1;
                nud_ovo.Value = 1;
                nud_queijo.Value = 1;
                calculalanches();
            }
            if (cbx_lanches.Text.Equals("X-Egg Bacon"))
            {
                nud_alface.Value = 0;
                nud_bacon.Value = 1;
                nud_hamb_carne.Value = 1;
                nud_ovo.Value = 1;
                nud_queijo.Value = 1;
                calculalanches();
            }
        }

        public void calculalanches()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RafaDBEntities"].ConnectionString))
            {
                Double vl_soma_valor = 0;
                SqlCommand command = new SqlCommand("sp_calcula_lanche", con);
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@cd_alface", SqlDbType.Int)).Value = nud_alface.Value;
                command.Parameters.Add(new SqlParameter("@cd_bacon", SqlDbType.Int)).Value = nud_bacon.Value;
                command.Parameters.Add(new SqlParameter("@cd_hamburguer_carne", SqlDbType.Int)).Value = nud_hamb_carne.Value;
                command.Parameters.Add(new SqlParameter("@cd_ovo", SqlDbType.Int)).Value = nud_ovo.Value;
                command.Parameters.Add(new SqlParameter("@cd_queijo", SqlDbType.Int)).Value = nud_queijo.Value;
                command.Parameters.Add(new SqlParameter("@vl_soma_valor", SqlDbType.Float)).Value = nud_queijo.Value;
                command.Parameters["@vl_soma_valor"].Direction = ParameterDirection.Output;
                try
                {
                    command.ExecuteNonQuery();
                    vl_soma_valor = Convert.ToDouble(command.Parameters["@vl_soma_valor"].Value);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                tbx_valor_total.Text = Convert.ToString(vl_soma_valor);
            }

        }

        public void preenchegrid()
        {
            try
            {
                DataTable oTable = new DataTable();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RafaDBEntities"].ConnectionString))
                {
                    string sql = "Select * from tb_pedidos";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader oDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    oTable.Load(oDataReader);
                    dgw_Pedidos.DataSource = oTable;
                    formataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void formataGridView()
        {
            var grade = dgw_Pedidos;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grade.RowsDefaultCellStyle.BackColor = Color.White;
            grade.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            grade.Columns[0].HeaderText = "Núm. Pedido";
            grade.Columns[1].HeaderText = "Nome do Cliente";
            grade.Columns[2].HeaderText = "Lanche";
            grade.Columns[3].HeaderText = "Status Pedido";
            grade.Columns[4].HeaderText = "Data Entrada";
            grade.Columns[5].HeaderText = "Qtd Alface";
            grade.Columns[6].HeaderText = "Qtd Bacon";
            grade.Columns[7].HeaderText = "Qtd Hamburg Carne";
            grade.Columns[8].HeaderText = "Qtd ovo";
            grade.Columns[9].HeaderText = "Qtd Queijo";
            grade.Columns[10].HeaderText = "Valor do Pedido";
            grade.Columns[0].Width = 70;
            grade.Columns[1].Width = 150;
        }

        private void btn_faz_pedido_Click(object sender, EventArgs e)
        {
            if (txb_nome_cliente.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Preencher o nome do cliente");
                return;
            }


            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["RafaDBEntities"].ConnectionString))
            {
                SqlCommand command = new SqlCommand("sp_faz_pedido", cnn);
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@nm_cliente", SqlDbType.Text)).Value = txb_nome_cliente.Text;
                command.Parameters.Add(new SqlParameter("@nm_lanche", SqlDbType.Text)).Value = cbx_lanches.Text;
                command.Parameters.Add(new SqlParameter("@cd_alface", SqlDbType.Int)).Value = nud_alface.Value;
                command.Parameters.Add(new SqlParameter("@cd_bacon", SqlDbType.Int)).Value = nud_bacon.Value;
                command.Parameters.Add(new SqlParameter("@cd_hamburguer_carne", SqlDbType.Int)).Value = nud_hamb_carne.Value;
                command.Parameters.Add(new SqlParameter("@cd_ovo", SqlDbType.Int)).Value = nud_ovo.Value;
                command.Parameters.Add(new SqlParameter("@cd_queijo", SqlDbType.Int)).Value = nud_queijo.Value;
                try
                {
                    command.ExecuteNonQuery();
                    cnn.Close();
                    preenchegrid();
                    limpaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    cnn.Close();
                }
            }
            min = 0; sec = 0;

        }


        private void limpaCampos()
        {
            txb_nome_cliente.Text = "";
            cbx_lanches.Text = "X-Bacon";
            nud_alface.Value = 0;
            nud_bacon.Value = 1;
            nud_hamb_carne.Value = 1;
            nud_ovo.Value = 0;
            nud_queijo.Value = 1;
            calculalanches();
        }

        int prom_alface = 0;
        
        private void nud_alface_ValueChanged(object sender, EventArgs e)
        {
            calculalanches();
            if (nud_bacon.Value == 0 && nud_alface.Value > 0 && prom_alface == 0)
            {
                lbl_light.Text = "Light: Se o lanche tem alface e não tem bacon, ganha 10% de desconto. ";
                prom_alface = 1;
            }
            if (nud_bacon.Value > 0 && prom_alface == 1)
            {
                lbl_light.Text = "";
                prom_alface = 0;
            }
        }

        private void nud_bacon_ValueChanged(object sender, EventArgs e)
        {
            calculalanches();
            if (nud_bacon.Value == 0 && nud_alface.Value > 0 && prom_alface == 0)
            {
                lbl_light.Text = "Light: Se o lanche tem alface e não tem bacon, ganha 10% de desconto. ";
                prom_alface = 1;
            }
            if (nud_bacon.Value > 0  && prom_alface == 1)
            {
                lbl_light.Text = "";
                prom_alface = 0;
            }
        }

        private void nud_hamb_carne_ValueChanged(object sender, EventArgs e)
        {
            calculalanches();
            if (nud_hamb_carne.Value > 2)
            {
                lbl_m_carne.Text = lbl_promocoes.Text + "Muita carne: A cada 3 porções de carne o cliente só paga 2. ";
            }
            else if (nud_hamb_carne.Value <= 2)
            {
                lbl_m_carne.Text = "";
            }
        }

        private void nud_ovo_ValueChanged(object sender, EventArgs e)
        {
            calculalanches();
        }

        private void nud_queijo_ValueChanged(object sender, EventArgs e)
        {
            calculalanches();
            if (nud_queijo.Value > 2)
            {
                lbl_m_queijo.Text = "Muito queijo: A cada 3 porções de carne o cliente só paga 2. ";
            }
            else if (nud_queijo.Value <= 2)
            {
                lbl_m_queijo.Text = "";
            }
        }

        int min = 0, sec = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            
            if(min < 9)
            {
                if (sec < 10)
                {
                    tbx_timer.Text = "0" + Convert.ToString(min) + ":0" + Convert.ToString(sec);
                }
                else
                    tbx_timer.Text = "0" + Convert.ToString(min) + ":" + Convert.ToString(sec);
            }
            else if (sec < 10)
                {
                    tbx_timer.Text = Convert.ToString(min) + ":0" + Convert.ToString(sec);
                }
                else
                    tbx_timer.Text = Convert.ToString(min) + ":" + Convert.ToString(sec);
        }

        
    }
}
