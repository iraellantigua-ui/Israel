using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Helpers
{
    public static class SessionManager
    {
        private static Usuario _usuarioActual;
        private static string _turnoActual;
        private static int _idAsignacionTurno;

        public static Usuario UsuarioActual
        {
            get { return _usuarioActual; }
            set { _usuarioActual = value; }
        }

        public static string TurnoActual
        {
            get { return _turnoActual; }
            set { _turnoActual = value; }
        }

        public static int IdAsignacionTurno
        {
            get { return _idAsignacionTurno; }
            set { _idAsignacionTurno = value; }
        }

        public static bool IsLoggedIn
        {
            get { return _usuarioActual != null; }
        }

        public static bool IsAdmin
        {
            get { return _usuarioActual != null && _usuarioActual.RolNombre == "Administrador"; }
        }

        public static bool IsSupervisor
        {
            get { return _usuarioActual != null && _usuarioActual.RolNombre == "Supervisor"; }
        }

        public static bool IsCajero
        {
            get { return _usuarioActual != null && _usuarioActual.RolNombre == "Cajero"; }
        }

        public static void Logout()
        {
            _usuarioActual = null;
            _turnoActual = null;
            _idAsignacionTurno = 0;
        }
    }
}