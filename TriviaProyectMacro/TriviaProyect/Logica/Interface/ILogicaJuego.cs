﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Logica.Interface
{
    public interface ILogicaJuego
    {
        void Alta_Juego(Juego a);
        void Baja_Juego(Juego a);
        void Modificacion_Juego(Juego a);
		Juego Buscar_Administrador(Juego a);
		List<Juego> Listar_Juego();

    }
}
