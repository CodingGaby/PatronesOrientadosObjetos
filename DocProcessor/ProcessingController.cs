namespace DocProcessor
{
    /// Esta clase se encarga de gestionar el procesamiento de documentos.
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 29/11/2024
    /// Versión: 1.0.0.0
    /// Modificación: 29/11/2024
    public class ProcessingController
    {
        private static ProcessingController instance; //!< Instancia única del controlador.

        /// Constructor privado para implementar el patrón Singleton.
        /// Autor: Jorge Gabriel Garcia Osorio
        /// Fecha: 29/11/2024
        private ProcessingController() { }

        /// Obtiene la instancia única del controlador.
        /// Autor: Jorge Gabriel Garcia Osorio
        /// Fecha: 29/11/2024
        /// Versión: 1.0.0.0
        /// Modificación: 29/11/2024
        /// <returns>Instancia única del controlador</returns>
        public static ProcessingController GetInstance()
        {
            if (instance == null)
            {
                instance = new ProcessingController();
            }
            return instance;
        }

        /// Procesa un documento utilizando un procesador específico.
        /// Autor: Jorge Gabriel Garcia Osorio
        /// Fecha: 29/11/2024
        /// Versión: 1.0.0.0
        /// Modificación: 29/11/2024
        /// <param name="processor">Procesador de documentos</param>
        public void ProcessDocument(DocumentProcessor processor)
        {
            processor.Process();
        }
    }
}
