namespace CodeFlow
{
    internal class Project
    {
        /// <summary>
        /// The name of the project.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Path to the project.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// The project's settings.
        /// </summary>
        private ProjectData ProjectData;

        public Project(string path, string name)
        {
            Path = path;
        }
    }
}