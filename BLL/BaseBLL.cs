﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class BaseBLL
    {
        public Usuario UsuarioLogado { get; set; }
        public BaseBLL()
        {
            if (stUsuario.UsuarioLogado != null)
            {
                UsuarioLogado = stUsuario.UsuarioLogado;
            }            
        }
    }
}
