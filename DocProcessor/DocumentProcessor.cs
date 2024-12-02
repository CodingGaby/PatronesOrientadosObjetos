namespace DocProcessor
{
    /// Esta clase define la plantilla para procesar documentos.
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 29/11/2024
    /// Versión: 1.0.0.0
    /// Modificación: 29/11/2024
    public abstract class DocumentProcessor
    {
        /// Procesa un documento siguiendo pasos comunes.
        /// Autor: Jorge Gabriel Garcia Osorio
        /// Fecha: 29/11/2024
        /// Versión: 1.0.0.0
        /// Modificación: 29/11/2024
        public void Process()
        {
            LoadDocument();
            ParseDocument();
            SaveDocument();
        }

        /// Carga el documento.
        protected abstract void LoadDocument();

        /// Analiza el contenido del documento.
        protected abstract void ParseDocument();

        /// Guarda los cambios en el documento.
        protected abstract void SaveDocument();
    }
}
