
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersGenNHibernate.CP.MouseRiders;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;
        
        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}


private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
private static Random rng = new Random(); //variable aleatoria de los generadores

private static string RandomString(int size) //metodo que genera Strings aleatorios de x tamaño 
{
    
    char[] buffer = new char[size];
    int datatest = 0;
    for (int i = 0; i < size; i++)
    {
        buffer[i] = _chars[rng.Next(_chars.Length)];
        datatest = rng.Next(_chars.Length);
    }
    return new string(buffer);
}



public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes


                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");
                //UsuarioCEN usuario = new UsuarioCEN ();
                //usuario.CrearUsuario ("pepe@gmail.com", "pepe", "lopez lopez", "espanya", 666666666, 0, DateTime.Now);
                
                #region Usuario
                IUsuarioCAD _IUsuarioCAD = new UsuarioCAD ();
                UsuarioCEN usuarioCEN = new UsuarioCEN (_IUsuarioCAD);

                IList<UsuarioEN> users;
                users=new List<UsuarioEN>(); //lista de Usuarios
                
                //Usuario1
                UsuarioEN usuario1EN = new UsuarioEN ();
                usuario1EN.Email = "pepe@gmail.com";
                usuario1EN.Nombre = "pepe";
                usuario1EN.Apellidos = "lopez lopez";
                usuario1EN.Contrasenya = "1234";
                usuario1EN.Telefono = 666666666;
                usuario1EN.Pais = "espanya";
                usuario1EN.Puntuacion = 1000;
                usuario1EN.FechaRegistro = DateTime.Now;
                int oid_usu = usuarioCEN.CrearUsuario (usuario1EN.Email, usuario1EN.Nombre, usuario1EN.Apellidos, usuario1EN.Pais, usuario1EN.Telefono, usuario1EN.Puntuacion, usuario1EN.FechaRegistro, usuario1EN.Contrasenya, "user1");
                usuario1EN.Id = oid_usu;
                users.Add(usuario1EN);
  
                //Usuario2
                UsuarioEN usuario2EN = new UsuarioEN ();
                usuario2EN.Email = "jorge@gmail.com";
                usuario2EN.Nombre = "jorge";
                usuario2EN.Apellidos = "sanchez sanchez";
                usuario2EN.Contrasenya = "1234";
                usuario2EN.Telefono = 696969696;
                usuario2EN.Pais = "espanya";
                usuario2EN.Puntuacion = 2000;
                usuario2EN.FechaRegistro = DateTime.Now;
                int oid_usu2 = usuarioCEN.CrearUsuario (usuario2EN.Email, usuario2EN.Nombre, usuario2EN.Apellidos, usuario2EN.Pais, usuario2EN.Telefono, usuario2EN.Puntuacion, usuario2EN.FechaRegistro, usuario2EN.Contrasenya, "user2");
                usuario2EN.Id = oid_usu2;
                users.Add(usuario2EN);

                //Usuario3
                UsuarioEN usuario3EN = new UsuarioEN ();
                usuario3EN.Email = "javi@gmail.com";
                usuario3EN.Nombre = "javi";
                usuario3EN.Apellidos = "moreno sanchez";
                usuario3EN.Contrasenya = "12345";
                usuario3EN.Telefono = 678901234;
                usuario3EN.Pais = "mexico";
                usuario3EN.Puntuacion = 3000;
                usuario3EN.FechaRegistro = DateTime.Now;
                int oid_usu3 = usuarioCEN.CrearUsuario (usuario3EN.Email, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Pais, usuario3EN.Telefono, usuario3EN.Puntuacion, usuario3EN.FechaRegistro, usuario3EN.Contrasenya, "user3");
                usuario3EN.Id = oid_usu3;
                users.Add(usuario3EN);

                //Usuario4
                UsuarioEN usuario4EN = new UsuarioEN ();
                usuario4EN.Email = "pedro@gmail.com";
                usuario4EN.Nombre = "pedro";
                usuario4EN.Apellidos = "moreno sanchez";
                usuario4EN.Contrasenya = "12345";
                usuario4EN.Telefono = 678901234;
                usuario4EN.Pais = "mexico";
                usuario4EN.Puntuacion = 3000;
                usuario4EN.FechaRegistro = DateTime.Now;
                usuario4EN.Id = usuarioCEN.CrearUsuario (usuario4EN.Email, usuario4EN.Nombre, usuario4EN.Apellidos, usuario4EN.Pais, usuario4EN.Telefono, usuario4EN.Puntuacion, usuario4EN.FechaRegistro, usuario4EN.Contrasenya, "user4");
                users.Add(usuario4EN);    


                #endregion

                #region Mensaje
                IMensajeCAD _IMensajeCAD = new MensajeCAD ();
                MensajeCEN mensajeCEN = new MensajeCEN (_IMensajeCAD);

                //Mensaje1
                MensajeEN mensaje1EN = new MensajeEN ();
                mensaje1EN.Asunto = "hablemos";
                mensaje1EN.Adjunto = "adjunto.pdf";
                mensaje1EN.Texto = "erase una vez un lorem ipsum";
                mensaje1EN.Tipo = T_MensajeEnum.privado;
                IList<UsuarioEN> es_recibido = new List<UsuarioEN>();
                es_recibido.Add (usuario1EN);
                mensaje1EN.Es_recibido = es_recibido;
                mensaje1EN.Es_enviado = usuario2EN;
                IList<int> ses_recibido = new List<int>();
                ses_recibido.Add (usuario2EN.Id);
                ses_recibido.Add (usuario3EN.Id);
                mensajeCEN.CrearMensaje (mensaje1EN.Asunto, mensaje1EN.Texto, mensaje1EN.Adjunto, mensaje1EN.Tipo, mensaje1EN.Es_enviado.Id, ses_recibido);

                //Mensaje2
                MensajeEN mensaje2EN = new MensajeEN ();
                mensaje2EN.Asunto = "hablemos de nuevo";
                mensaje2EN.Adjunto = "adjunto.pdf";
                mensaje2EN.Texto = "erase una vez un lorem ipsum";
                mensaje2EN.Tipo = T_MensajeEnum.admin;
                IList<UsuarioEN> es_recibido2 = new List<UsuarioEN>();
                es_recibido2.Add (usuario2EN);
                mensaje2EN.Es_recibido = es_recibido2;
                mensaje2EN.Es_enviado = usuario1EN;
                IList<int> ses_recibido1 = new List<int>();
                ses_recibido1.Add (usuario2EN.Id);
                mensajeCEN.CrearMensaje (mensaje2EN.Asunto, mensaje2EN.Texto, mensaje2EN.Adjunto, mensaje2EN.Tipo, mensaje2EN.Es_enviado.Id, ses_recibido1);

                //Mensaje3
                MensajeEN mensaje3EN = new MensajeEN ();
                mensaje3EN.Asunto = "hablemos por tercera vez";
                mensaje3EN.Adjunto = "adjunto.pdf";
                mensaje3EN.Texto = "erase una vez un lorem ipsum";
                mensaje3EN.Tipo = T_MensajeEnum.privado;
                IList<UsuarioEN> es_recibido3 = new List<UsuarioEN>();
                es_recibido3.Add (usuario3EN);
                mensaje3EN.Es_recibido = es_recibido3;
                mensaje3EN.Es_enviado = usuario1EN;
                IList<int> ses_recibido2 = new List<int>();
                ses_recibido2.Add (usuario3EN.Id);
                mensajeCEN.CrearMensaje (mensaje3EN.Asunto, mensaje3EN.Texto, mensaje3EN.Adjunto, mensaje3EN.Tipo, mensaje3EN.Es_enviado.Id, ses_recibido2);

                //Mensaje4
                MensajeEN mensaje4EN = new MensajeEN ();
                mensaje4EN.Asunto = "hablemos por cuarta vez";
                mensaje4EN.Adjunto = "adjunto.pdf";
                mensaje4EN.Texto = "erase una vez un lorem ipsum";
                mensaje4EN.Tipo = T_MensajeEnum.notificacion;
                IList<UsuarioEN> es_recibido4 = new List<UsuarioEN>();
                es_recibido4.Add (usuario3EN);
                mensaje4EN.Es_recibido = es_recibido4;
                mensaje4EN.Es_enviado = usuario1EN;
                IList<int> ses_recibido4 = new List<int>();
                ses_recibido4.Add (usuario3EN.Id);
                int oid1 = mensajeCEN.CrearMensaje (mensaje4EN.Asunto, mensaje4EN.Texto, mensaje4EN.Adjunto, mensaje4EN.Tipo, mensaje4EN.Es_enviado.Id, ses_recibido4);

                //Mensaje5
                MensajeEN mensaje5EN = new MensajeEN ();
                mensaje5EN.Asunto = "hablemos por quinta";
                mensaje5EN.Adjunto = "adjunto.pdf";
                mensaje5EN.Texto = "erase una vez un lorem ipsum";
                mensaje5EN.Tipo = T_MensajeEnum.notificacion;
                IList<UsuarioEN> es_recibido5 = new List<UsuarioEN>();
                es_recibido5.Add (usuario2EN);
                mensaje5EN.Es_recibido = es_recibido5;
                mensaje5EN.Es_enviado = usuario3EN;
                IList<int> ses_recibido5 = new List<int>();
                ses_recibido5.Add (usuario3EN.Id);
                int oid2 = mensajeCEN.CrearMensaje (mensaje5EN.Asunto, mensaje5EN.Texto, mensaje5EN.Adjunto, mensaje5EN.Tipo, mensaje5EN.Es_enviado.Id, ses_recibido5);

                #endregion

                #region ControladorNotificaciones y Mensaje
                IControladorNotificacionesCAD _IControladorNotificacionesCAD = new ControladorNotificacionesCAD ();
                ControladorNotificacionesCEN controladorNotificacionesCEN = new ControladorNotificacionesCEN (_IControladorNotificacionesCAD);

                ControladorNotificacionesEN controladorNotificacionesEN = new ControladorNotificacionesEN ();
                controladorNotificacionesEN.EnviaN = null;

                int oidNot = controladorNotificacionesCEN.CrearCNotificaciones ();
                controladorNotificacionesEN = _IControladorNotificacionesCAD.ReadOIDDefault (oidNot);
                IList<MensajeEN> menz = new List<MensajeEN>();
                controladorNotificacionesEN.EnviaN = menz;
                controladorNotificacionesEN.EnviaN.Add (mensaje4EN);
                controladorNotificacionesEN.EnviaN.Add (mensaje5EN);

                _IControladorNotificacionesCAD.ModificarCNotificaciones (controladorNotificacionesEN);

                mensajeCEN.RelacionaMensaje (oid1, controladorNotificacionesEN.Id);
                mensajeCEN.RelacionaMensaje (oid2, controladorNotificacionesEN.Id);

                #endregion

                #region Permiso
                IPermisoCAD _IPermisoCAD = new PermisoCAD ();
                PermisoCEN permisoCEN = new PermisoCEN (_IPermisoCAD);

                //Permiso1
                PermisoEN permiso1EN = new PermisoEN ();
                permiso1EN.PermisoOID.Rol = T_RolEnum.usuario;
                permiso1EN.PermisoOID.Permiso = "foro";
                permiso1EN.Permisos = "{permiso1: acceder a contactos}";

                permisoCEN.CrearPermiso (permiso1EN.PermisoOID.Rol, permiso1EN.PermisoOID.Permiso, permiso1EN.Permisos);

                //Permiso2
                PermisoEN permiso2EN = new PermisoEN ();
                permiso2EN.PermisoOID.Rol = T_RolEnum.usuario;
                permiso2EN.PermisoOID.Permiso = "general";
                permiso2EN.Permisos = "{permiso2: acceder a fotos}";

                PermisoEN_OID permi = permisoCEN.CrearPermiso (permiso2EN.PermisoOID.Rol, permiso2EN.PermisoOID.Permiso, permiso2EN.Permisos);

                //Permiso3
                PermisoEN permiso3EN = new PermisoEN ();
                permiso3EN.PermisoOID.Rol = T_RolEnum.admin;
                permiso3EN.PermisoOID.Permiso = "administracion";
                permiso3EN.Permisos = "{permiso3: acceder a fotos de gatitos}";

                PermisoEN_OID permi1 = permisoCEN.CrearPermiso (permiso3EN.PermisoOID.Rol, permiso3EN.PermisoOID.Permiso, permiso3EN.Permisos);

                IList<PermisoEN_OID> ss1 = new List<PermisoEN_OID>();
                ss1.Add (permiso1EN.PermisoOID);
                usuarioCEN.RelacionaPermiso (oid_usu, ss1);

                ss1.Add (permiso3EN.PermisoOID);
                usuarioCEN.RelacionaPermiso (oid_usu2, ss1);

                ss1.Clear ();
                ss1.Add (permiso2EN.PermisoOID);
                usuarioCEN.RelacionaPermiso (oid_usu3, ss1);
                #endregion

                #region Recompensa
                IRecompensaCAD _IRecompensaCAD = new RecompensaCAD ();
                RecompensaCEN recompensaCEN = new RecompensaCEN (_IRecompensaCAD);

                //Recompensa1
                RecompensaEN recompensa1EN = new RecompensaEN ();
                recompensa1EN.Nombre = "veterano";
                recompensa1EN.Descripcion = "adelantos un dia antes de las reviews";
                recompensa1EN.Puntuacion = 2500;

                int oid_r = recompensaCEN.CrearRecompensa (recompensa1EN.Nombre, recompensa1EN.Descripcion, recompensa1EN.Puntuacion);

                //Recompensa2
                RecompensaEN recompensa2EN = new RecompensaEN ();
                recompensa2EN.Nombre = "amateur";
                recompensa2EN.Descripcion = "sientete orgulloso";
                recompensa2EN.Puntuacion = 500;

                int oid_r1 = recompensaCEN.CrearRecompensa (recompensa2EN.Nombre, recompensa2EN.Descripcion, recompensa2EN.Puntuacion);

                //Recompensa3
                RecompensaEN recompensa3EN = new RecompensaEN ();
                recompensa3EN.Nombre = "iniciado";
                recompensa3EN.Descripcion = "empiezas a no tener vida social, enhorabuena";
                recompensa3EN.Puntuacion = 1500;

                int oid_r2 = recompensaCEN.CrearRecompensa (recompensa3EN.Nombre, recompensa3EN.Descripcion, recompensa3EN.Puntuacion);
                /*
                 *
                 *  IList<int> ss2 = new List<int>();
                 *  ss2.Add (oid_r);
                 *  usuarioCEN.RelacionaRecompensa (oid_usu, ss2);
                 *
                 *  ss2.Add (oid_r1);
                 *  usuarioCEN.RelacionaRecompensa (oid_usu2, ss2);
                 *
                 *  ss2.Clear ();
                 *  ss2.Add (oid_r2);
                 *  ss2.Add (oid_r);
                 *  usuarioCEN.RelacionaRecompensa (oid_usu3, ss2);
                 */
                #endregion

                #region Denuncia
                IDenunciaCAD _IDenunciaCAD = new DenunciaCAD ();
                DenunciaCEN denunciaCEN = new DenunciaCEN (_IDenunciaCAD);

                //Denuncia1
                DenunciaEN denuncia1EN = new DenunciaEN ();
                denuncia1EN.Fecha = DateTime.Now;
                denuncia1EN.Motivo = "huele mal";

                int oid_d = denunciaCEN.CrearDenuncia (denuncia1EN.Motivo, usuario2EN.Id, denuncia1EN.Fecha, usuario1EN.Id);

                //Denuncia2
                DenunciaEN denuncia2EN = new DenunciaEN ();
                denuncia2EN.Fecha = DateTime.Now;
                denuncia2EN.Motivo = "huele bastante mal";

                int oid_d2 = denunciaCEN.CrearDenuncia (denuncia2EN.Motivo, usuario3EN.Id, denuncia2EN.Fecha, usuario1EN.Id);

                //Denuncia3
                DenunciaEN denuncia3EN = new DenunciaEN ();
                denuncia3EN.Fecha = DateTime.Now;
                denuncia3EN.Motivo = "huele muy mal";

                int oid_d3 = denunciaCEN.CrearDenuncia (denuncia3EN.Motivo, usuario4EN.Id, denuncia3EN.Fecha, usuario1EN.Id);


                IList<int> ss3 = new List<int>();
                ss3.Add (oid_d);
                usuarioCEN.RelacionaDenuncia (oid_usu, ss3);

                ss3.Add (oid_d3);
                usuarioCEN.RelacionaDenuncia (oid_usu2, ss3);

                ss3.Clear ();
                ss3.Add (oid_d2);
                usuarioCEN.RelacionaDenuncia (oid_usu3, ss3);


                #endregion

                #region Bloqueo
                /*
                 *  IBloqueoCAD _IBloqueoCAD = new BloqueoCAD ();
                 *  BloqueoCEN bloqueoCEN = new BloqueoCEN (_IBloqueoCAD);
                 *
                 *  BloqueoEN bloqueoEN = new BloqueoEN ();
                 *  bloqueoEN.FechaInicio = DateTime.Now;
                 *  bloqueoEN.FechaFin = DateTime.Now;
                 *  IList<int> ss4 = new List<int>();
                 *  ss4.Add (oid_d);
                 *  ss4.Add (oid_d2);
                 *  ss4.Add (oid_d3);
                 *  int oid_b = bloqueoCEN.CrearBloqueo (ss4, usuario1EN.Email, DateTime.Now, DateTime.Now);
                 *
                 *  usuarioCEN.RelacionaBloqueo (oid_usu, oid_b);
                 */
                #endregion

                #region Administrador
                IAdministradorCAD _IAdministradorCAD = new AdministradorCAD ();
                AdministradorCEN administradorCEN = new AdministradorCEN (_IAdministradorCAD);

                AdministradorEN administradorEN = new AdministradorEN ();
                administradorEN.Apellidos = "perez juan";
                administradorEN.Contrasenya = "peeedro";
                administradorEN.Email = "loreto@gmal.com";
                administradorEN.FechaRegistro = DateTime.Now;
                administradorEN.Nombre = "loreto";
                administradorEN.Pais = "pais valencia";
                administradorEN.Puntuacion = 5000;
                administradorEN.Telefono = 666777888;

                administradorCEN.CrearAdministrador (administradorEN.Email, administradorEN.Nombre, administradorEN.Apellidos, administradorEN.Pais, administradorEN.Telefono, administradorEN.Puntuacion, administradorEN.FechaRegistro, administradorEN.Contrasenya, "user5");

                #endregion

                #region Admin_foro
                IAdmin_foroCAD _IAdmin_foroCAD = new Admin_foroCAD ();
                Admin_foroCEN admin_foroCEN = new Admin_foroCEN (_IAdmin_foroCAD);

                AdministradorEN admin_foroEN = new AdministradorEN ();
                admin_foroEN.Apellidos = "perez juan";
                admin_foroEN.Contrasenya = "peeedro";
                admin_foroEN.Email = "maria@gmal.com";
                admin_foroEN.FechaRegistro = DateTime.Now;
                admin_foroEN.Nombre = "maria";
                admin_foroEN.Pais = "catalunya";
                admin_foroEN.Puntuacion = 100;
                admin_foroEN.Telefono = 666999111;

                int oid_adminf = admin_foroCEN.CrearAdmin_foro (admin_foroEN.Email, admin_foroEN.Nombre, admin_foroEN.Apellidos, admin_foroEN.Pais, admin_foroEN.Telefono, admin_foroEN.Puntuacion, admin_foroEN.FechaRegistro, admin_foroEN.Contrasenya, "user6");

                #endregion

                #region Redactor
                IRedactorCAD _IRedactorCAD = new RedactorCAD ();
                RedactorCEN redactorCEN = new RedactorCEN (_IRedactorCAD);

                RedactorEN redactorEN = new RedactorEN ();
                redactorEN.Apellidos = "pereza juana";
                redactorEN.Contrasenya = "peeedro1";
                redactorEN.Email = "marco@gmal.com";
                redactorEN.FechaRegistro = DateTime.Now;
                redactorEN.Nombre = "marco";
                redactorEN.Pais = "pais vasco";
                redactorEN.Puntuacion = 10000;
                redactorEN.Telefono = 666345111;

                redactorCEN.CrearRedactor (redactorEN.Email, redactorEN.Nombre, redactorEN.Apellidos, redactorEN.Pais, redactorEN.Telefono, redactorEN.Puntuacion, redactorEN.FechaRegistro, redactorEN.Contrasenya, "user7");

                #endregion

                #region Encuesta
                IEncuestaCAD _IEncuestaCAD = new EncuestaCAD ();
                EncuestaCEN encuestaCEN = new EncuestaCEN (_IEncuestaCAD);

                EncuestaEN encuestaEN = new EncuestaEN ();
                encuestaEN.Titulo = "satisfaccion de los usuarios";
                encuestaEN.Descripcion = "como de satisfechos estan los usuarios";
                int oid_e = encuestaCEN.CrearEncuesta (encuestaEN.Titulo, encuestaEN.Descripcion, false);

                #endregion

                #region Pregunta
                IPreguntaCAD _IPreguntaCAD = new PreguntaCAD ();
                PreguntaCEN preguntaCEN = new PreguntaCEN (_IPreguntaCAD);

                PreguntaEN pregunta1EN = new PreguntaEN ();
                pregunta1EN.Pregunta = "�esta satisfecho?";
                pregunta1EN.Tipo = T_PreguntaEnum.radio;
                pregunta1EN.Pertenece = encuestaEN;
                int oid_p1 = preguntaCEN.CrearPregunta (pregunta1EN.Pregunta, pregunta1EN.Tipo, oid_e);

                PreguntaEN pregunta2EN = new PreguntaEN ();
                pregunta2EN.Pregunta = "�que puntuacion le da la asignatura DSM?";
                pregunta2EN.Tipo = T_PreguntaEnum.numerico;
                pregunta2EN.Pertenece = encuestaEN;
                int oid_p2 = preguntaCEN.CrearPregunta (pregunta2EN.Pregunta, pregunta2EN.Tipo, oid_e);

                PreguntaEN pregunta3EN = new PreguntaEN ();
                pregunta3EN.Pregunta = "�que cambiaria de nuestra web?";
                pregunta3EN.Tipo = T_PreguntaEnum.radio;
                pregunta3EN.Pertenece = encuestaEN;
                int oid_p3 = preguntaCEN.CrearPregunta (pregunta3EN.Pregunta, pregunta3EN.Tipo, oid_e);

                #endregion

                #region Respuesta
                IRespuestaCAD _IRespuestaCAD = new RespuestaCAD ();
                RespuestaCEN respuestaCEN = new RespuestaCEN (_IRespuestaCAD);

                RespuestaEN respuesta1_1EN = new RespuestaEN ();
                respuesta1_1EN.Contador = 0;
                respuesta1_1EN.Frecuencia = 0;
                respuesta1_1EN.Respuesta = "mucho";
                respuesta1_1EN.Tipo = T_PreguntaEnum.radio;
                respuestaCEN.CrearRespuesta (respuesta1_1EN.Respuesta, respuesta1_1EN.Tipo, oid_p1, respuesta1_1EN.Contador, respuesta1_1EN.Frecuencia);

                RespuestaEN respuesta1_2EN = new RespuestaEN ();
                respuesta1_2EN.Contador = 0;
                respuesta1_2EN.Frecuencia = 0;
                respuesta1_2EN.Respuesta = "poco";
                respuesta1_2EN.Tipo = T_PreguntaEnum.radio;
                respuestaCEN.CrearRespuesta (respuesta1_2EN.Respuesta, respuesta1_2EN.Tipo, oid_p1, respuesta1_2EN.Contador, respuesta1_2EN.Frecuencia);

                RespuestaEN respuesta2_1EN = new RespuestaEN ();
                respuesta2_1EN.Contador = 0;
                respuesta2_1EN.Frecuencia = 0;
                respuesta2_1EN.Respuesta = "1";
                respuesta2_1EN.Tipo = T_PreguntaEnum.numerico;
                respuestaCEN.CrearRespuesta (respuesta2_1EN.Respuesta, respuesta2_1EN.Tipo, oid_p2, respuesta2_1EN.Contador, respuesta2_1EN.Frecuencia);

                RespuestaEN respuesta2_2EN = new RespuestaEN ();
                respuesta2_2EN.Contador = 0;
                respuesta2_2EN.Frecuencia = 0;
                respuesta2_2EN.Respuesta = "2";
                respuesta2_2EN.Tipo = T_PreguntaEnum.numerico;
                respuestaCEN.CrearRespuesta (respuesta2_2EN.Respuesta, respuesta2_2EN.Tipo, oid_p2, respuesta2_2EN.Contador, respuesta2_2EN.Frecuencia);

                RespuestaEN respuesta3_1EN = new RespuestaEN ();
                respuesta3_1EN.Contador = 0;
                respuesta3_1EN.Frecuencia = 0;
                respuesta3_1EN.Respuesta = "todo";
                respuesta3_1EN.Tipo = T_PreguntaEnum.radio;
                respuestaCEN.CrearRespuesta (respuesta3_1EN.Respuesta, respuesta3_1EN.Tipo, oid_p3, respuesta3_1EN.Contador, respuesta3_1EN.Frecuencia);

                RespuestaEN respuesta3_2EN = new RespuestaEN ();
                respuesta3_2EN.Contador = 0;
                respuesta3_2EN.Frecuencia = 0;
                respuesta3_2EN.Respuesta = "nada";
                respuesta3_2EN.Tipo = T_PreguntaEnum.radio;
                respuestaCEN.CrearRespuesta (respuesta3_2EN.Respuesta, respuesta3_2EN.Tipo, oid_p3, respuesta3_2EN.Contador, respuesta3_2EN.Frecuencia);


                #endregion

                #region Seccion
                ISeccionCAD _ISeccionCAD = new SeccionCAD ();
                SeccionCEN seccionCEN = new SeccionCEN (_ISeccionCAD);

                SeccionEN seccionEN = new SeccionEN ();
                seccionEN.Nombre = "ArticulosPC";
                int oid_s = seccionCEN.CrearSeccion (seccionEN.Nombre);

                SeccionEN seccion1EN = new SeccionEN ();
                seccionEN.Nombre = "NoticiasPC";
                int oid_s1 = seccionCEN.CrearSeccion (seccionEN.Nombre);

                SeccionEN seccion2EN = new SeccionEN ();
                seccionEN.Nombre = "Semanal";
                int oid_s2 = seccionCEN.CrearSeccion (seccionEN.Nombre);

                #endregion

                #region Articulo
                IArticuloCAD _IArticuloCAD = new ArticuloCAD ();
                ArticuloCEN articuloCEN = new ArticuloCEN (_IArticuloCAD);

                IList<ArticuloEN> articulos;
                articulos = new List<ArticuloEN>(); //lista con todos los articulos

                ArticuloEN articulo1EN = new ArticuloEN ();
                articulo1EN.Autor = usuario1EN.Email;
                articulo1EN.Contador = 0;
                articulo1EN.Contenido = "Articulo1.html";
                articulo1EN.ContenidoDescargable = "documento.pdf";
                articulo1EN.Fecha = DateTime.Now;
                articulo1EN.Puntuacion = 0;
                articulo1EN.Titulo = "Final Fantasy XV";
                articulo1EN.Subtitulo = "Todo lo que necesitas saber";
                articulo1EN.Portada = "https://i1.sndcdn.com/artworks-000127833709-vqi28b-t500x500.jpg";
                articulo1EN.Descripcion = "Por lo general, los juegos que tardan una década en salir tienen problemas. ¿Acaso olvidaste la catástrofe que fue Duke Nukem Forever? Pero Square Enix cambió de planes y eso incluía un nombre nuevo con una historia un poco distinta.";
                int oid_a1 = articuloCEN.CrearArticulo (oid_s, articulo1EN.Titulo, articulo1EN.Autor, articulo1EN.Contenido, articulo1EN.ContenidoDescargable, articulo1EN.Puntuacion, articulo1EN.Fecha, articulo1EN.Contador, articulo1EN.Subtitulo, articulo1EN.Portada, articulo1EN.Descripcion);
                articulo1EN.Id = oid_a1;
                articulos.Add(articulo1EN);

                ArticuloEN articulo2EN = new ArticuloEN ();
                articulo2EN.Autor = usuario1EN.Email;
                articulo2EN.Contador = 0;
                articulo2EN.Contenido = "Articulo2.html";
                articulo2EN.ContenidoDescargable = "documento.pdf";
                articulo2EN.Fecha = DateTime.Now;
                articulo2EN.Puntuacion = 0;
                articulo2EN.Titulo = "Planet Coaster";
                articulo2EN.Subtitulo = "Tu loco parque de atracciones";
                articulo2EN.Portada = "https://forums.planetcoaster.com/attachment.php?attachmentid=352&d=1466078141";
                articulo2EN.Descripcion = "Construir tu propio parque de atracciones, sin límites, con gigantescas montañas rusas y grandes espectáculos. ¿Quién podría resistirse a algo así? Planet Coaster te permite crear tu particular Disney World con una sorprendente libertad de acción.";
                int oid_a2 = articuloCEN.CrearArticulo (oid_s1, articulo2EN.Titulo, articulo2EN.Autor, articulo2EN.Contenido, articulo2EN.ContenidoDescargable, articulo2EN.Puntuacion, articulo2EN.Fecha, articulo2EN.Contador, articulo2EN.Subtitulo, articulo2EN.Portada, articulo2EN.Descripcion);
                articulo2EN.Id = oid_a2;
                articulos.Add(articulo2EN);

                ArticuloEN articulo3EN = new ArticuloEN ();
                articulo3EN.Autor = usuario1EN.Email;
                articulo3EN.Contador = 0;
                articulo3EN.Contenido = "Articulo3.html";
                articulo3EN.ContenidoDescargable = "documento.pdf";
                articulo3EN.Fecha = DateTime.Now;
                articulo3EN.Puntuacion = 0;
                articulo3EN.Titulo = "Call of Duty";
                articulo3EN.Subtitulo = "Modern Warfare Remastered";
                articulo3EN.Portada = "http://static.mensup.fr/photos/132266/carre-call-of-duty-modern-warfare-remastered-les-images.jpg";
                articulo3EN.Descripcion = "El juego que revolucionó el shooter moderno hace casi diez años vuelve con una de las mejores remasterizaciones que hemos podido probar hasta la fecha.";
                int oid_a3 = articuloCEN.CrearArticulo (oid_s2, articulo3EN.Titulo, articulo3EN.Autor, articulo3EN.Contenido, articulo3EN.ContenidoDescargable, articulo3EN.Puntuacion, articulo3EN.Fecha, articulo3EN.Contador, articulo3EN.Subtitulo, articulo3EN.Portada, articulo3EN.Descripcion);
                articulo3EN.Id = oid_a3;
                articulos.Add(articulo3EN);
                
                #endregion

                #region Foro

                /*
                 *
                 * IForoCAD _IForoCAD = new ForoCAD ();
                 * ForoCEN foroCEN = new ForoCEN (_IForoCAD);
                 *
                 * ForoEN foroEN = new ForoEN ();
                 * int oid_f = foroCEN.CrearForo ();
                 */
                #endregion

                #region Hilo
                IHiloCAD _IHiloCAD = new HiloCAD ();
                HiloCEN hiloCEN = new HiloCEN (_IHiloCAD);

                IList<HiloEN> hilos;
                hilos = new List<HiloEN>();

                HiloEN hilo1EN = new HiloEN ();
                hilo1EN.Creador = admin_foroEN.Email;
                hilo1EN.Fecha = DateTime.Now;
                hilo1EN.NumComentarios = 2;
                hilo1EN.Titulo = "hilo1";
                int oid_h1 = hiloCEN.CrearHilo (hilo1EN.Creador, hilo1EN.Fecha, hilo1EN.NumComentarios, hilo1EN.Titulo);
                hilo1EN.Id = oid_h1;
                hilos.Add(hilo1EN);

                HiloEN hilo2EN = new HiloEN ();
                hilo2EN.Creador = redactorEN.Email;
                hilo2EN.Fecha = DateTime.Now;
                hilo2EN.NumComentarios = 2;
                hilo2EN.Titulo = "hilo2madebyanonimo";
                int oid_h2 = hiloCEN.CrearHilo (hilo2EN.Creador, hilo2EN.Fecha, hilo2EN.NumComentarios, hilo2EN.Titulo);
                hilo2EN.Id = oid_h2;
                hilos.Add(hilo2EN);

                //BUCLE QUE GENERA 10 HILOS DE FORMA AUTOMATICA ASIGNANDOLOS A UN USUARIO ALEATORIO Y CON UN TITULO ALEATORIO
                
                for (int i = 0; i < 10; i++) 
                {
                    HiloEN hilo3EN = new HiloEN();
                    hilo3EN.Creador = users[rng.Next(users.Count)].Email;
                    hilo3EN.Fecha = DateTime.Now;
                    hilo3EN.NumComentarios = 2;
                    hilo3EN.Titulo = RandomString(10);
                    int oid_h3 = hiloCEN.CrearHilo(hilo3EN.Creador, hilo3EN.Fecha, hilo3EN.NumComentarios, hilo3EN.Titulo);
                    hilo3EN.Id = oid_h3;
                    hilos.Add(hilo3EN);
                };


                #endregion

                #region Comentario
                IComentarioCAD _IComentarioCAD = new ComentarioCAD ();
                ComentarioCEN comentarioCEN = new ComentarioCEN (_IComentarioCAD);

                ComentarioEN comentario1EN = new ComentarioEN ();
                comentario1EN.Contenido = "ahhhhhhhhg, siempre todo a ultima hora";
                comentario1EN.Creador = usuario1EN.Email;
                comentario1EN.Fecha = DateTime.Now;
                comentario1EN.Valoracion = 0;
                int oid_c1 = comentarioCEN.CrearComentario (comentario1EN.Creador, comentario1EN.Fecha, comentario1EN.Contenido, comentario1EN.Valoracion);
                    

                ComentarioEN comentario2EN = new ComentarioEN ();
                comentario2EN.Contenido = "eso es mentira";
                comentario2EN.Creador = usuario2EN.Email;
                comentario2EN.Fecha = DateTime.Now;
                comentario2EN.Valoracion = 0;
                int oid_c2 = comentarioCEN.CrearComentario (comentario2EN.Creador, comentario2EN.Fecha, comentario2EN.Contenido, comentario2EN.Valoracion);

                ComentarioEN comentario3EN = new ComentarioEN ();
                comentario3EN.Contenido = "eso es falso";
                comentario3EN.Creador = usuario2EN.Email;
                comentario3EN.Fecha = DateTime.Now;
                comentario3EN.Valoracion = 0;
                int oid_c3 = comentarioCEN.CrearComentario (comentario3EN.Creador, comentario3EN.Fecha, comentario3EN.Contenido, comentario3EN.Valoracion);

                ComentarioEN comentario4EN = new ComentarioEN ();
                comentario4EN.Contenido = "jajaja, vaya mierda de pagina";
                comentario4EN.Creador = usuario3EN.Email;
                comentario4EN.Fecha = DateTime.Now;
                comentario4EN.Valoracion = 0;
                int oid_c4 = comentarioCEN.CrearComentario (comentario4EN.Creador, comentario4EN.Fecha, comentario4EN.Contenido, comentario4EN.Valoracion);

                ComentarioEN comentario5EN = new ComentarioEN ();
                comentario5EN.Contenido = "mirate re:zero de una puta vez manu y tu tambien sergio";
                comentario5EN.Creador = usuario4EN.Email;
                comentario5EN.Fecha = DateTime.Now;
                comentario5EN.Valoracion = 0;
                int oid_c5 = comentarioCEN.CrearComentario (comentario5EN.Creador, comentario5EN.Fecha, comentario5EN.Contenido, comentario5EN.Valoracion);

                ComentarioEN comentario6EN = new ComentarioEN ();
                comentario6EN.Contenido = "este es un comentario";
                comentario6EN.Creador = usuario2EN.Email;
                comentario6EN.Fecha = DateTime.Now;
                comentario6EN.Valoracion = 0;
                int oid_c6 = comentarioCEN.CrearComentario (comentario6EN.Creador, comentario6EN.Fecha, comentario6EN.Contenido, comentario6EN.Valoracion);

                ComentarioEN comentario7EN = new ComentarioEN ();
                comentario7EN.Contenido = "hola mundo";
                comentario7EN.Creador = usuario1EN.Email;
                comentario7EN.Fecha = DateTime.Now;
                comentario7EN.Valoracion = 0;
                int oid_c7 = comentarioCEN.CrearComentario (comentario7EN.Creador, comentario7EN.Fecha, comentario7EN.Contenido, comentario7EN.Valoracion);

                ComentarioEN comentario8EN = new ComentarioEN ();
                comentario8EN.Contenido = "sergio cambia el jodido comentario cabron";
                comentario8EN.Creador = usuario3EN.Email;
                comentario8EN.Fecha = DateTime.Now;
                comentario8EN.Valoracion = 0;
                int oid_c8 = comentarioCEN.CrearComentario (comentario8EN.Creador, comentario8EN.Fecha, comentario8EN.Contenido, comentario8EN.Valoracion);

                ComentarioEN comentario9EN = new ComentarioEN ();
                comentario9EN.Contenido = "Rising discretito? Sera a nivel tecnico, porque jugablemente es top del genero.";
                comentario9EN.Creador = usuario3EN.Email;
                comentario9EN.Fecha = DateTime.Now;
                comentario9EN.Valoracion = 0;
                int oid_c9 = comentarioCEN.CrearComentario (
                        comentario9EN.Creador,
                        comentario9EN.Fecha,
                        comentario9EN.Contenido,
                        comentario9EN.Valoracion);

                ComentarioEN comentario10EN = new ComentarioEN ();
                comentario10EN.Contenido = "Estos juegos con tantos menús el idioma es un handicap para mí, espero que lo acaben traduciendo";
                comentario10EN.Creador = usuario3EN.Email;
                comentario10EN.Fecha = DateTime.Now;
                comentario10EN.Valoracion = 0;
                int oid_c10 = comentarioCEN.CrearComentario (
                        comentario10EN.Creador,
                        comentario10EN.Fecha,
                        comentario10EN.Contenido,
                        comentario10EN.Valoracion);

                ComentarioEN comentario11EN = new ComentarioEN ();
                comentario11EN.Contenido = "Demo probada, y bueno, no está mal, bastante variado para ser una demo tan corta, pero no se si es mi estilo de juego. Los personajes (sobretodo el chaval) me ha parecido pesadísimo. Aunque la historia que se intuye no tiene mala pinta.";
                comentario11EN.Creador = usuario3EN.Email;
                comentario11EN.Fecha = DateTime.Now;
                comentario11EN.Valoracion = 0;
                int oid_c11 = comentarioCEN.CrearComentario (
                        comentario11EN.Creador,
                        comentario11EN.Fecha,
                        comentario11EN.Contenido,
                        comentario11EN.Valoracion);

                ComentarioEN comentario12EN = new ComentarioEN ();
                comentario12EN.Contenido = "Ya lo e jugado  y es lo que me esperaba , el antiguo Nier con las mecanicas de Platinum para el combate , una gozada  Lo que me sorprende al leer estas impresiones es lo de los angulos de camara , ya que esos angulos los hacia el primer Nier ";
                comentario12EN.Creador = usuario3EN.Email;
                comentario12EN.Fecha = DateTime.Now;
                comentario12EN.Valoracion = 0;
                int oid_c12 = comentarioCEN.CrearComentario (
                        comentario12EN.Creador,
                        comentario12EN.Fecha,
                        comentario12EN.Contenido,
                        comentario12EN.Valoracion);

                ComentarioEN comentario13EN = new ComentarioEN ();
                comentario13EN.Contenido = "no se porque vas de listo solo por ser una demo cuando los responsables son platinium games, despues de bayoneta y metal gear rising no hay porque dudar solo por ser una demo";
                comentario13EN.Creador = usuario3EN.Email;
                comentario13EN.Fecha = DateTime.Now;
                comentario13EN.Valoracion = 0;
                int oid_c13 = comentarioCEN.CrearComentario (
                        comentario13EN.Creador,
                        comentario13EN.Fecha,
                        comentario13EN.Contenido,
                        comentario13EN.Valoracion);


                comentarioCEN.RelacionaArticulo (oid_c1, oid_a1);
                comentarioCEN.RelacionaArticulo (oid_c2, oid_a1);
                comentarioCEN.RelacionaArticulo (oid_c3, oid_a2);
                comentarioCEN.RelacionaArticulo (oid_c4, oid_a2);
                comentarioCEN.RelacionaHilo (oid_c5, oid_h1);
                comentarioCEN.RelacionaHilo (oid_c6, oid_h1);
                comentarioCEN.RelacionaHilo (oid_c7, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c8, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c9, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c10, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c11, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c12, oid_h2);
                comentarioCEN.RelacionaHilo (oid_c13, oid_h2);

            IList<ComentarioEN> comentarios;
            comentarios = new List<ComentarioEN>(); //lista de comentarios
            
            for(int i=0; i<100; i++){
                int picker=0; //variable que se usa para la toma de decisiones a la hora de enlazar los comentarios a hilos, articulos, etc...
                comentario1EN = new ComentarioEN ();
                comentario1EN.Contenido = RandomString(100);
                comentario1EN.Creador = users[rng.Next(users.Count)].Email;
                comentario1EN.Fecha = DateTime.Now;
                comentario1EN.Valoracion = rng.Next(6);
                oid_c1 = comentarioCEN.CrearComentario (comentario1EN.Creador, comentario1EN.Fecha, comentario1EN.Contenido, comentario1EN.Valoracion);
                picker=rng.Next(0, 2);
                
                if (picker == 0) //se relaciona con un articulo aleatorio
                {
                    comentarioCEN.RelacionaArticulo(oid_c1, articulos[rng.Next(articulos.Count)].Id);
                }
                else //se relaciona con un hilo aleatorio
                {
                    comentarioCEN.RelacionaHilo(oid_c1, hilos[rng.Next(hilos.Count)].Id);
                }

                comentarios.Add(comentario1EN);
            };
             

            Console.WriteLine("He añadido todos los comentarios"); //true
                #endregion

                #region Metodos

                //Bloquear Usuario (funciona tras muchas modificaciones!!!)
                AdministradorCP administradorCP = new AdministradorCP ();
                Console.WriteLine ("Bloquear Usuario Result : " + administradorCP.BloquearUsuario (oid_usu3, 2)); //false
                Console.WriteLine ("Bloquear Usuario Result1 : " + administradorCP.BloquearUsuario (oid_usu, 10)); //true


                //Actualizar Puntuacion de Articulo (funciona tras modificaciones leves!!!)
                Console.WriteLine ("Actualizar puntuacion Result :" + articuloCEN.ActualizarPuntuacion (oid_a2, 5.0F));
                Console.WriteLine ("Actualizar puntuacion Result1 :" + articuloCEN.ActualizarPuntuacion (oid_a2, 3.0F));
                Console.WriteLine ("Actualizar puntuacion Result2 :" + articuloCEN.ActualizarPuntuacion (oid_a2, 4.0F));
                Console.WriteLine ("Actualizar puntuacion Result3 :" + articuloCEN.ActualizarPuntuacion (oid_a2, 5.0F));


                //Realizar Encuesta (funciona tras modificaciones leves!!!)
                EncuestaCP encuestaCP = new EncuestaCP ();
                IList<String> ss5 = new List<String>();
                ss5.Add ("mucho");
                ss5.Add ("1");
                ss5.Add ("todo");

                encuestaCP.RealizarEncuesta (oid_e, ss5);

                ss5.Clear ();
                ss5.Add ("mucho");
                ss5.Add ("2");
                ss5.Add ("todo");

                encuestaCP.RealizarEncuesta (oid_e, ss5);

                ss5.Clear ();
                ss5.Add ("poco");
                ss5.Add ("2");
                ss5.Add ("todo");

                encuestaCP.RealizarEncuesta (oid_e, ss5);
                //Si funciona, la respuesta mucho debe tener 2 en el contador, poco debe tener 1, 1 debe tener 1, 2 debe tener 2, todo debe tener 3 y el resto 0


                //Generar Estadisticas (funciona tras modificaciones leves!!!)
                encuestaCP.GenerarEstadisticas ();
                //Si funciona, la respuesta mucho debe tener 0.66, poco=0.33, 1=0.33, 2=0.66, todo=1.0


                //Autenticar (funciona a la primera!!!)
                //Console.WriteLine ("Autenticar Result :" + usuarioCEN.Autenticar (1, usuario1EN.Email, usuario1EN.Contrasenya));
                //Console.WriteLine ("Autenticar Result1 :" + usuarioCEN.Autenticar (1, usuario1EN.Email, "jasfjskgj"));


                //Calcular Puntuacion (funciona tras modificaciones tontas!!!)
                Console.WriteLine ("Calcular Puntuacion Result :" + usuarioCEN.CalcularPuntuacion (oid_usu3, 100));  //debe devolver 3100
                Console.WriteLine ("Calcular Puntuacion Result1 :" + usuarioCEN.CalcularPuntuacion (oid_usu2, 100)); //debe devolver 2100


                //Denunciar Usuario (funciona tras modificaciones leves!!!)
                Console.WriteLine ("Denunciar Usuario Result :" + usuarioCEN.DenunciarUsuario (oid_usu3, oid_usu2, "Tiene alargamiento de pene"));


                //Actualizar Puntuacion de Comentario (funciona tras modificaciones leves!!!)
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, -1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, -1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, 1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, 1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, 1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c1, 1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c2, -1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c2, -1));
                Console.WriteLine ("Actualizar Puntuacion Result :" + comentarioCEN.ActualizarPuntuacion (oid_c2, -2));
                //Si va, el comentario 1 se quedará con 2 puntos y el 2 con -2


                //Calcular Recompensas (funciona tras muchas modificaciones!!!)
                UsuarioCP usuarioCP = new UsuarioCP ();
                Console.WriteLine ("Calcular Recompensas Result :" + usuarioCP.CalcularRecompensas (oid_usu));
                Console.WriteLine ("Calcular Recompensas Result :" + usuarioCP.CalcularRecompensas (oid_usu2));
                Console.WriteLine ("Calcular Recompensas Result :" + usuarioCP.CalcularRecompensas (oid_usu3));
                Console.WriteLine ("Calcular Recompensas Result :" + usuarioCP.CalcularRecompensas (oid_adminf));


                //Enviar Notificaciones (funciona tras dos horas y tener que hacerlo entero!!!)
                RecompensaEN rec = new RecompensaEN ();
                rec.Id = oid_r2;
                PermisoEN per = new PermisoEN ();
                per.PermisoOID = permi;
                PermisoEN per1 = new PermisoEN ();
                per1.PermisoOID = permi1;
                ControladorNotificacionesCP controlador = new ControladorNotificacionesCP ();
                controlador.EnviarNotificaciones (null, null, "para todos los usuarios", "Texto de prueba de metodos", "Adjunto.tequiero.png");
                controlador.EnviarNotificaciones (null, rec, "para los que tienen la recompensa 3", "Texto de prueba de metodos", "Adjunto.tequiero.png");
                controlador.EnviarNotificaciones (per1, null, "para los que tienen el permiso 3", "Texto de prueba de metodos", "Adjunto.tequiero.png");
                controlador.EnviarNotificaciones (per, rec, "para los que tienen la recompensa 3 y el permiso 2", "Texto de prueba de metodos", "Adjunto.tequiero.png");

                #endregion

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
