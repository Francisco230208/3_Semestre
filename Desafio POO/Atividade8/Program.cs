using Atividade8;

            IAutenticavel usuario = new Usuario();
            IAutenticavel admin = new Administrador();

            Console.WriteLine(usuario.Autenticar("123"));   // true
            Console.WriteLine(admin.Autenticar("admin"));   // true
            Console.WriteLine(admin.Autenticar("123"));     // fals