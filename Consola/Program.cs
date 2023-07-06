using Biblioteca;

Persona dueño = new Persona("Jose", 29, "voy@rtucasa.com");

Animal paciente1 = new Animal("Juancho", new DateOnly(2023, 1, 2), dueño);

Veterinario veterinario1 = new Veterinario("Fercho", 47, new DateOnly(1980, 3, 4));

Visita visita = new Visita(new DateTime(2023, 7, 6, 10, 30, 0), paciente1, veterinario1);

Pets pets = new Pets();

pets.AgregarProfesional(veterinario1);
pets.AgregarPaciente(paciente1);
pets.CrearVisita(visita);

pets.ImprimirVisitas(new DateOnly(2023, 7, 6));