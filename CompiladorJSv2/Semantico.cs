
namespace CompiladorJSv2
{

    public enum Alcance
    {
        Public,
        Private,
        Static,
        Protected,
        Sealed,
        Abstract
    }
    public enum TipoDato
    {
        INT,
        STRING,
        DOBLE,
        CHAR,
        BOOL,
        OBJECT,
        BYTE,
        CADENA,
        NADA
    }
    public enum Regreso
    {
        INT,
        STRING,
        DOUBLE,
        CHAR,
        BOOL,
        OBJECT,
        BYTE,
        VOID
    }
    public enum TipoVariable
    {
        variableLocal,
        parametro
    }


    /// <summary>
    /// Es el nodo donde se guardan los registros de clases en la TSClases
    /// </summary>
    public class NodoClase
    {
        private string lexema;
        private Alcance miAlcance;
        private string herencia; // lexema de clase a heredar
        private int renglonDeclaracion;
        private int[] referencias;

        private Dictionary<string, NodoAtributo> tablaSimbolosAtributos =
            new Dictionary<string, NodoAtributo>();

        private Dictionary<string, NodoMetodo> tablaSimbolosMetodos =
            new Dictionary<string, NodoMetodo>();

        public string Lexema
        {
            get
            {
                return lexema;
            }

            set
            {
                lexema = value;
            }
        }
        public Alcance MiAlcance
        {
            get
            {
                return miAlcance;
            }

            set
            {
                miAlcance = value;
            }
        }
        public string Herencia
        {
            get
            {
                return herencia;
            }

            set
            {
                herencia = value;
            }
        }
        public int RenglonDeclaracion
        {
            get
            {
                return renglonDeclaracion;
            }

            set
            {
                renglonDeclaracion = value;
            }
        }
        public int[] Referencias
        {
            get
            {
                return referencias;
            }

            set
            {
                referencias = value;
            }
        }
        public Dictionary<string, NodoAtributo> TSA
        {
            get
            {
                return tablaSimbolosAtributos;
            }

            set
            {
                tablaSimbolosAtributos = value;
            }
        }
        public Dictionary<string, NodoMetodo> TSM
        {
            get
            {
                return tablaSimbolosMetodos;
            }

            set
            {
                tablaSimbolosMetodos = value;
            }
        }
    }
    public class NodoAtributo
    {
        public string lexema;
        public Alcance miAlcance;
        public TipoDato miTipo;
        public string valor;
        public string direccionMemoria;
        public int reglonDec;
        public int[] referencias;

        public string Lexema
        {
            get
            {
                return lexema;
            }

            set
            {
                lexema = value;
            }
        }
        public Alcance MiAlcance
        {
            get
            {
                return miAlcance;
            }
            set
            {
                miAlcance = value;
            }
        }
        public TipoDato MiTipo
        {
            get
            {
                return miTipo;
            }
            set
            {
                miTipo = value;
            }
        }
        public string Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        public string DireccionMemoria
        {
            get
            {
                return direccionMemoria;
            }
            set
            {
                direccionMemoria = value;
            }
        }
        public int RenglonDec
        {
            get
            {
                return reglonDec;
            }
            set
            {
                reglonDec = value;
            }
        }
        public int[] Referencias
        {
            get
            {
                return referencias;
            }
            set
            {
                referencias = value;
            }
        }
    }  // Modificado
    public class NodoVariable
    {
        public string lexema;
        public TipoDato miTipoDato;
        public string valor;
        public TipoVariable miTipoVariable;
        public string direccionMemoria;
        public int reglonDec;
        public int[] referencias;

        public string Lexema
        {
            get
            {
                return lexema;
            }

            set
            {
                lexema = value;
            }
        }
        public TipoVariable MitipoVariable
        {
            get
            {
                return miTipoVariable;
            }
            set
            {
                miTipoVariable = value;
            }
        }
        public TipoDato MiTipo
        {
            get
            {
                return miTipoDato;
            }
            set
            {
                miTipoDato = value;
            }
        }
        public string Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        public string DireccionMemoria
        {
            get
            {
                return direccionMemoria;
            }
            set
            {
                direccionMemoria = value;
            }
        }
        public int RenglonDec
        {
            get
            {
                return reglonDec;
            }
            set
            {
                reglonDec = value;
            }
        }
        public int[] Referencias
        {
            get
            {
                return referencias;
            }
            set
            {
                referencias = value;
            }
        }
    } // Modificado
    public class NodoMetodo
    {
        public string lexema;
        public Alcance miAlcance;
        public Regreso miRegreso;
        public int renglonDeclaracion;
        public int[] referencias;

        public Dictionary<object, NodoVariable> TablaSimbolosVariables =
            new Dictionary<object, NodoVariable>();

        public string Lexema
        {
            get
            {
                return lexema;
            }

            set
            {
                lexema = value;
            }
        }
        public Alcance MiAlcance
        {
            get
            {
                return miAlcance;
            }

            set
            {
                miAlcance = value;
            }
        }
        public Regreso MiRegreso
        {
            get
            {
                return miRegreso;
            }

            set
            {
                miRegreso = value;
            }
        }
        public int RenglonDeclaracion
        {
            get
            {
                return renglonDeclaracion;
            }

            set
            {
                renglonDeclaracion = value;
            }
        }
        public int[] Referencias
        {
            get
            {
                return referencias;
            }

            set
            {
                referencias = value;
            }
        }

        public Dictionary<object, NodoVariable> TSV
        {
            get
            {
                return TablaSimbolosVariables;
            }

            set
            {
                TablaSimbolosVariables = value;
            }
        }



    }   // Modificado

    static public class TablaSimbolos
    {
        public static List<Error> listaErroresSemantico;

        //public static String Claseactual;

        public static NodoClase ClaseActiva;
        public static NodoMetodo MetodoActivo;
        public static bool herencia;


        //public static bool herencia;

        //dicionario de datos como una tabla de simbolos
        //tabla de simbolos raiz (principal)

        private static Dictionary<object, NodoClase> tablaSimbolosClase =
            new Dictionary<object, NodoClase>();

        /// <summary>
        /// propiedades del diccionario de nodo clases
        /// </summary>
        public static Dictionary<object, NodoClase> TablaSimbolosClase
        {
            get
            {
                return tablaSimbolosClase;
            }

            set
            {
                tablaSimbolosClase = value;
            }
        }

        #region METODOS para TS de CLASES

        /// <summary>
        /// Metodo para insertar los nodos de clases en la TS
        /// </summary>
        /// <param name="miNodoClase">nodo clase</param>
        static public void InsertarNodoClase(NodoClase miNodoClase)
        {
            if (!TablaSimbolosClase.ContainsKey(miNodoClase.Lexema)) // verificar una colision
            {
                TablaSimbolosClase.Add(miNodoClase.Lexema, miNodoClase);
            }
            else
            {
                var error = new Error()
                {
                    Codigo = 601,
                    Linea = miNodoClase.RenglonDeclaracion,
                    MensajeError = "Ya existe una implementacion con ese identificador",
                    TipoError = tipoError.Semantico
                };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }
        }

        public static void ExisteVariable(string lexema, NodoMetodo miNodoMetodo, int linea)
        {
            if (!miNodoMetodo.TSV.ContainsKey(lexema))
            {
                var error = new Error() { Codigo = 619, Linea = linea, MensajeError = "Variable no encontrada", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }
        }


        static public NodoClase BusquedaNodoClasePorLexema(string lexema)
        {
            if (TablaSimbolosClase.ContainsKey(lexema))
            {
                return TablaSimbolosClase.FirstOrDefault(x => x.Key.ToString() == lexema).Value;
            }
            else
            {
                var error = new Error() { Codigo = 602, Linea = 0, MensajeError = "No existe en el contexto una clase con ese nombre", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
                return null;
            }

        }

        static public void ExisteClaseHeredada(string lexema)
        {
            herencia = true;
            if (!TablaSimbolosClase.ContainsKey(lexema))
            {
                var error = new Error() { Codigo = 603, Linea = 0, MensajeError = "No se encontro la clase a heredar", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
                herencia = false;
            }
        }

        #endregion
        #region METODOS para TS de Atributos
        static public void InsertarNodoAtributo
            (NodoAtributo miNodoAtributo, NodoClase nodoClaseActual)
        {
            if (!nodoClaseActual.TSA.ContainsKey(miNodoAtributo.lexema))
            {
                nodoClaseActual.TSA.Add(miNodoAtributo.lexema, miNodoAtributo);
            }
            else
            {
                var error = new Error() { Codigo = 601, Linea = miNodoAtributo.reglonDec, MensajeError = "Ya existe un miembro con ese identificador", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }

        }


        #endregion
        #region METODOS para TS de Metodos
        public static void InsertarNodoMetodo(NodoMetodo miNodoMetodo, List<NodoVariable> misParametros, NodoClase nodoClaseActiva)
        {
            if (nodoClaseActiva.Lexema != miNodoMetodo.lexema && !nodoClaseActiva.TSM.ContainsKey(miNodoMetodo.lexema)) // verificar que el nombre de la clase no se uso
            {
                if (!nodoClaseActiva.TSM.ContainsKey(miNodoMetodo.lexema))
                {

                    foreach (var item in misParametros)
                    {
                        miNodoMetodo.TablaSimbolosVariables.Add(item.lexema, item);
                    }
                    nodoClaseActiva.TSM.Add(miNodoMetodo.lexema, miNodoMetodo);

                }
                else
                {
                    // configurar el diccionario de datos o tablash para que acepte colisiones y haga
                    //listas anidadas
                    // algoritmo que soporte
                    // metodo de sobrecarga 
                    //for anidados

                    //    nodoClaseActiva.TSM.Add(miNodoMetodo.lexema, miNodoMetodo);
                }
            }
            else
            {
                var error = new Error() { Codigo = 604, Linea = miNodoMetodo.RenglonDeclaracion, MensajeError = "Tu nombre de metodo no puede llamarse como el nombre de la clase", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }
        }

        #endregion
        #region METODOS para TS de Variables
        public static void InsertarNodoVariable(NodoVariable nodoVariable, NodoClase nodoClaseActiva, string nombreMetodoActivo )
        {
            if (!nodoClaseActiva.TSM.ContainsKey(nodoVariable.Lexema) || TablaSimbolos.TablaSimbolosClase.ContainsKey(nodoVariable.Lexema)) 
            {
                var nodoMetodo = nodoClaseActiva.TSM.SingleOrDefault(x => x.Key == nombreMetodoActivo).Value;
                if (!nodoMetodo.TablaSimbolosVariables.ContainsKey(nodoVariable.Lexema))
                {
                    nodoMetodo.TablaSimbolosVariables.Add(nodoVariable.Lexema, nodoVariable);
                }
                else
                {
                    var error = new Error() { Codigo = 605, Linea = nodoVariable.RenglonDec, MensajeError = "Nombre e variable local ya existe en el contexto actual", TipoError = tipoError.Semantico };
                    TablaSimbolos.listaErroresSemantico.Add(error);
                }
            }
            else
            {
                var error = new Error() { Codigo = 606, Linea = nodoVariable.RenglonDec, MensajeError = "Tu nombre de meotod no puede llamarse como el nombre de la clase", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }
        }





        public static string ObtenerDireccionMemoriaRam(string lexemaVariable, NodoClase nodoClaseActiva, string nombreMetodoActivo)
        {
            var resultado =
                nodoClaseActiva.TSM.FirstOrDefault(x => x.Key == nombreMetodoActivo).Value.TablaSimbolosVariables.FirstOrDefault(y => y.Key.ToString() == lexemaVariable).Value.direccionMemoria;
            return resultado;

        }

        public static NodoVariable obtenerNodoVariable(string lexemaVariable, NodoClase nodoClaseActiva, string nombreMetodoActivo)
        {
            var resultado =
                nodoClaseActiva.TSM.FirstOrDefault(x => x.Key == nombreMetodoActivo).Value.TablaSimbolosVariables.FirstOrDefault(y =>
                y.Key.ToString() == lexemaVariable).Value;
            return resultado;
        }

        static public void ExisteVaraible(string lexema, NodoMetodo minoMetodo, int line)
        {
            herencia = true;
            if (!minoMetodo.TSV.ContainsKey(lexema))
            {
                var error = new Error() { Codigo = 619, Linea = line, MensajeError = "Variable no encontrada", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
                herencia = false;
            }
        }





        #endregion

    }

}
