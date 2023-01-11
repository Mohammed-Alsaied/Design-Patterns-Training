namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger

    {

        #region Save Implementation Using Lazy inialization Lazy<T> In .Net

        #region Use Cases For Singleton Pattern

        #endregion
        //Reakted Patterns
        //1.Abstract Factory:can be inplemented as a singleton 
        //2.Builder:can be inplemented as a singleton  
        //3.Prototype:can be inplemented as a singleton 
        //4.State Objects:are often inplemented as a singleton 

        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }
        protected Logger()
        {

        }

        /// <summary>
        /// SingletonOperation
        /// </summary> 

        public void Log(string message)
        {
            Console.WriteLine($"Message to log{message}");
        }

        #endregion

        #region Not Save Implementation
        ////public string UserName { get; set; }
        ////public string Password { get; set; }

        ////2.Create BckingFiled Static Nullable
        //private static Logger? _instance;

        ////3.Cretae Public Static Propperty
        //public static Logger Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new Logger();
        //        }
        //        return _instance;
        //    } 
        //}
        ////1.Make Constructor Protected/Private
        //protected Logger()
        //{

        //}


        ////Singleton Operation
        //public void Log(string message)
        //{
        //    Console.WriteLine($"Message to log{message}");
        //}

        #endregion
    }
}
