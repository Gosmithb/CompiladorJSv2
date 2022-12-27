
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
        NADA,
        parametro
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

    public class TablaSimbolos
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
        public static void InsertarNodoClase(NodoClase miNodoClase)
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

            if (!tablaSimbolosClase.ContainsKey(miNodoAtributo.lexema)) //Verificar que el nombre de la clase no se uso
            {

                //if (miNodoAtributo.miAlcance == Alcance.Public)
                //{
                if (!nodoClaseActual.TSA.ContainsKey(miNodoAtributo.lexema)) //Verificar que no exista
                {
                    nodoClaseActual.TSA.Add(miNodoAtributo.lexema, miNodoAtributo);
                }
                else
                {
                    var error = new Error() { Codigo = 607, Linea = miNodoAtributo.reglonDec, MensajeError = "Ya existe un miembro con ese identificador", TipoError = tipoError.Semantico };
                    TablaSimbolos.listaErroresSemantico.Add(error);
                }
                //}



            }
            else
            {
                var error = new Error() { Codigo = 607, Linea = miNodoAtributo.reglonDec, MensajeError = "Una variable no puede tener el mismo nombre de la clase", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }

        }

        #endregion
        #region METODOS PARA TS de METODOS
        public static void InsertarNodoMetodo(NodoMetodo miNodoMetodo, List<NodoVariable> misParametros, NodoClase nodoClaseActiva)
        {

            if (nodoClaseActiva.Lexema != miNodoMetodo.lexema && !nodoClaseActiva.TSM.ContainsKey(miNodoMetodo.lexema) && !nodoClaseActiva.TSA.ContainsKey(miNodoMetodo.lexema)) // verificar que el nombre de la clase no se uso
            {

                foreach (var item in misParametros)
                {
                    if (!miNodoMetodo.TablaSimbolosVariables.ContainsKey(item.lexema)) //reviso colision de parametros 
                    {
                        miNodoMetodo.TablaSimbolosVariables.Add(item.lexema, item);
                    }
                    else
                    {
                        var error = new Error() { Codigo = 605, Linea = miNodoMetodo.renglonDeclaracion, MensajeError = "No puedes declarar dos parametros con el mismo nombre", TipoError = tipoError.Semantico };
                        TablaSimbolos.listaErroresSemantico.Add(error);
                    }

                }
                nodoClaseActiva.TSM.Add(miNodoMetodo.lexema, miNodoMetodo);

            }
            else
            {
                var error = new Error() { Codigo = 604, Linea = miNodoMetodo.renglonDeclaracion, MensajeError = "Tu nombre de metodo no puede llamarse como el nombre de la clase, otro metodo o variable", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }




        }

        #endregion

        #region METODOS PARA TS de VARIABLES y PARAMETROS

        public static void InsertarNodoVariable(NodoVariable miNodoVariable, NodoClase nodoClaseActiva, string nombreMetodoActivo)
        {

            if (!nodoClaseActiva.TSM.ContainsKey(miNodoVariable.lexema) || TablaSimbolos.TablaSimbolosClase.ContainsKey(miNodoVariable.lexema))
            {
                var nodoMetodo = nodoClaseActiva.TSM.SingleOrDefault(x => x.Key == nombreMetodoActivo).Value;
                if (!nodoMetodo.TablaSimbolosVariables.ContainsKey(miNodoVariable.lexema))
                {
                    nodoMetodo.TablaSimbolosVariables
                        .Add(miNodoVariable.lexema, miNodoVariable);

                }
                else
                {
                    var error = new Error() { Codigo = 605, Linea = miNodoVariable.reglonDec, MensajeError = "nombre de variable local ya existe en el contexto", TipoError = tipoError.Semantico };
                    TablaSimbolos.listaErroresSemantico.Add(error);
                }
            }
            else
            {
                var error = new Error() { Codigo = 604, Linea = miNodoVariable.reglonDec, MensajeError = "Tu nombre de metodo no puede llamarse como el nombre de la clase", TipoError = tipoError.Semantico };
                TablaSimbolos.listaErroresSemantico.Add(error);
            }
        }



        public static void ExisteVariable(string lexema, NodoMetodo minoMetodo, int line)
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
