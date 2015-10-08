using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cablebilling
{
    public partial class customer : Form
    {
        public customer()
        {
          
            InitializeComponent();
            bindgrid();
        }
        function fc = new function();
        private void bindgrid()
        {
            string str = "select * from customer";
            gridcust.DataSource = fc.filldatatable(str);
        }

       
    
    
        private void clear()
        {
            csttxtname.Text = string.Empty;
            csttxtaddress.Text = string.Empty;
            csttxtmono.Text = string.Empty;
            csttxtstb.Text = string.Empty;
            csttxtbalance.Text = string.Empty;
            csttxtrent.Text = string.Empty;
            csttxtcharge.Text = string.Empty;
            

        }

        private void cstbtnsave_Click(object sender, EventArgs e)
        {
            if (csttxtname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Name!","Important Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            else if (csttxtaddress.Text == string.Empty)
             {
                 MessageBox.Show("Please enter a Address!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
     
            else if(csttxtmono.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Mobile.No!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (csttxtstb.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Stb.No!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (csttxtbalance.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Opening Balance!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (csttxtrent.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Monthly Rent!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (csttxtcharge.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Installation Charge!","Important Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string str = "insert into customer(c_name,address,mobile,con_date,stb_no,ob,monthly_rent,inst_charge)values('" + csttxtname.Text + "','" + csttxtaddress.Text + "','" + csttxtmono.Text + "','" + this.cstdtp.Value.ToString("dd/MM/yyyy") + "','" + csttxtstb.Text + "','" + csttxtbalance.Text + "','" + csttxtrent.Text + "','" + csttxtcharge.Text + "')";
                fc.executedml(str);
                MessageBox.Show("Customer Added Successfully");
                clear();
            }
        }

          
        
        
        private void gridcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row=this.gridcust.Rows[e.RowIndex];
                csttxtid.Text = row.Cells[0].Value.ToString();
                csttxtname.Text = row.Cells[1].Value.ToString();
                csttxtaddress.Text = row.Cells[2].Value.ToString();
                csttxtmono.Text = row.Cells[3].Value.ToString();
                cstdtp.Text = row.Cells[4].Value.ToString();
                csttxtstb.Text = row.Cells[5].Value.ToString();
                csttxtbalance.Text = row.Cells[6].Value.ToString();
                csttxtrent.Text = row.Cells[7].Value.ToString();
                csttxtcharge.Text = row.Cells[8].Value.ToString();
            }
        }

        private void cstbtnupdate_Click(object sender, EventArgs e)
        {
            string str="update customer set  c_name ='" +  csttxtname.Text + "',address='"+ csttxtaddress.Text  +"',mobile='"+ csttxtmono.Text +"',con_date= '"+  cstdtp.Text  +"',stb_no='"+ csttxtstb.Text +"',ob='"+ csttxtbalance.Text +"',monthly_rent='"+ csttxtrent.Text +"',inst_charge='"+  csttxtcharge.Text +"'";
            fc.executedml(str);
            bindgrid();
            clear();

        }
    
    
    }
}
           