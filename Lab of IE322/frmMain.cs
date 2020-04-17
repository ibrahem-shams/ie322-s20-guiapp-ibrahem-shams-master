using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace IE322_App_KAU
{
    public partial class frmMain : Form
    {
        string username = "ibrahem";
        string myPassword = "1234";
        bool loggedIn = false;
        
        int attempt = 1;
        int MaxAttempts = 3;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
          
            this.DialogResult = DialogResult.OK;
        }

       
        private void btnPic_Click(object sender, EventArgs e)
        {
            frmPic_1 frm = new frmPic_1();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            frmPic2 frm = new frmPic2();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

       

       

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (! loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   			
                        if (txtPassword.Text != myPassword)
                        {
                            
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            
                            attempt = 1; // reset the number of attempts
                            loggedIn = true;
                            MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          
                           

                            

                            btnLogin.Text = "Logout";
                           
                            
                            break; 
                        }//endif

                    }//endif
                }//end while
            }
            else 
            {
                btnLogin.Text = "Login";
                
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                
                {
                }
            }
           



        } //end login Button

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

      
        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

      
      
        
    }
}
