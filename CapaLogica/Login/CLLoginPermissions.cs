namespace CapaLogica.Login
{
    public static class CLLoginPermissions
    {
        public static bool Permissions(string action)
        {
            if (CapaSoporte.CSActiveUser.TipoPermiso.Contains(action)) return true;
            else return false;
        }
    }
}
