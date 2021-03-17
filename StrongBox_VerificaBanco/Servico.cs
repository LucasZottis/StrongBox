using System;
using System.ServiceProcess;

namespace VerificaBanco {
    static class Servico {
        public static void IniciarServico(string nomeServico, int tempoSegundos) {
            // Instancia um objeto para controle de serviço.
            ServiceController servico = new ServiceController(nomeServico);
            // Determina quanto tempo para concluir a operação.
            TimeSpan tempoLimite = TimeSpan.FromSeconds(tempoSegundos);
            // Inicia o serviço.
            servico.Start();
            // Aguarda até o estado do serviço seja executando ou até que esgote o tempo.
            servico.WaitForStatus(ServiceControllerStatus.Running, tempoLimite);
        }

        public static bool VerificaStatusServico(string nomeServico) {
            // Verificar o estado de um serviço especificado, 
            ServiceController servico = new ServiceController(nomeServico);
            // Retornado false caso qualquer coisa diferente de Running.
            if (servico.Status != ServiceControllerStatus.Running) {
                return false;
            } else {
                return true;
            }
        }

        public static void PararServico(string nomeServico, int tempoSegundos) {
            // Instancia um objeto para controle de serviço.
            ServiceController servico = new ServiceController(nomeServico);
            // Determina quanto tempo para concluir a operação.
            TimeSpan tempoLimite = TimeSpan.FromSeconds(tempoSegundos);
            // Inicia o serviço.
            servico.Stop();
            // Aguarda até o estado do serviço seja parado ou até que esgote o tempo.
            servico.WaitForStatus(ServiceControllerStatus.Stopped, tempoLimite);
        }
    }
}
