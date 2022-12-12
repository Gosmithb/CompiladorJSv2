using System.ComponentModel;

namespace CompiladorJSv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var lexico = new Lexico(txtBox.Text);
                lexico.EjecutarLexico();

                var objSintactico = new Sintactico(lexico.listaToken);
                objSintactico.EjecutarSintactico(objSintactico.listaTokens);

                

                List<Error> listaErroresLexico = lexico.listaErrorLexico;
                List<Error> listaErroresSintactico = objSintactico.listaError;

                //List<Token> listaSemantico = (from x in TablaSimbolos.listaErroresSemantico select x.Linea).ToList();
                
                List<Error> listaErrores = listaErroresLexico.Union(listaErroresSintactico).ToList();

                var Lista = new BindingList<Token>(lexico.listaToken);
                dataGridTokens.DataSource = null;
                dataGridTokens.DataSource = Lista;
                dataGridErrores.DataSource = null;
                dataGridErrores.DataSource = listaErrores;

                dataGridErroresSemantico.DataSource = null;
                dataGridErroresSemantico.DataSource = listaErroresSintactico;

            
            }
            catch 
            {
                MessageBox.Show("Tabla de simbolos variables error *TEMPORAL*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}