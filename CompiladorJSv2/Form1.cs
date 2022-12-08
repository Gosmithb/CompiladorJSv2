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

                List<Token> listaSemantico = objSintactico.listenerSemantico;

                List<Error> listaErrores = listaErroresLexico.Union(listaErroresSintactico).ToList();

                var Lista = new BindingList<Token>(lexico.listaToken);
                dataGridTokens.DataSource = null;
                dataGridTokens.DataSource = Lista;
                dataGridErrores.DataSource = null;
                dataGridErrores.DataSource = listaErrores;

                //var listaClases = (from x in TablaSimbolos.TablaSimbolosClase select x.Value).ToList();
                //var listaMetodos = (from x in TablaSimbolos.ClaseActiva.TSM select x.Value).ToList();
                //var listaAtributos = (from x in TablaSimbolos.ClaseActiva.TSA select x.Value).ToList();
                //var listaVariables = (from x in TablaSimbolos.MetodoActivo.TablaSimbolosVariables select x.Value).ToList();
            
                dataGridAtributos.DataSource = null;
                //dataGridAtributos.DataSource = listaAtributos;

                dataGridClases.DataSource = null;
                //dataGridClases.DataSource = listaClases;

                dataGridMetodos.DataSource = null;
                //dataGridMetodos.DataSource = listaMetodos;

                dataGridVariables.DataSource = null;
                //dataGridVariables.DataSource = listaVariables;
            
            }
            catch 
            {
                MessageBox.Show("Tabla de simbolos variables error *TEMPORAL*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}