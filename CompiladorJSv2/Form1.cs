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
                var objlista = new TablaSimbolos();
                

                List<Error> listaErroresLexico = lexico.listaErrorLexico;
                List<Error> listaErroresSintactico = objSintactico.listaError;
                List<Error> listaErroresSemantico = TablaSimbolos.listaErroresSemantico;

                List<Error> listaErrores = listaErroresLexico.Union(listaErroresSintactico).ToList();

                //Lista Tokens
                var Lista = new BindingList<Token>(lexico.listaToken);
                dataGridTokens.DataSource = null;
                dataGridTokens.DataSource = Lista;

                //Errores sintactico
                dataGridErrores.DataSource = null;
                dataGridErrores.DataSource = listaErrores;

                //Clases
                var listaClases = (from x in TablaSimbolos.TablaSimbolosClase select x.Value).ToList();
                dataGridClases.DataSource = null;
                dataGridClases.DataSource = listaClases;

                //Errores semantico
                dataGridErroresSemantico.DataSource = null;
                dataGridErroresSemantico.DataSource = listaErroresSemantico;

                //Atributos
                //var listaParametros = (from x in  select x.Value).ToList();

            
            }
            catch 
            {
                MessageBox.Show("Tabla de simbolos variables error *TEMPORAL*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}