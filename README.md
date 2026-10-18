# Move Mouse — build personalizado (PT-BR)

Fork de [sw3103/movemouse](https://github.com/sw3103/movemouse) com personalizações para uso próprio.
O Move Mouse simula atividade do usuário para evitar que a sessão do Windows bloqueie ou entre em suspensão.

## O que mudou neste fork

- **Interface em português (PT-BR):** janelas principal e de configurações, abas, rótulos, dicas (tooltips), botões e o status na bandeja.
- **Padrões prontos para trabalho** (valem em perfil novo, sem configurar nada):
  - Intervalo de 60s.
  - Pausa automática quando há atividade do usuário; retoma após 60s de inatividade.
  - Inicia junto com o Windows e já começa em execução ao abrir.
  - Minimiza para a bandeja quando parado.
- **Sem atualização automática / telemetria:** a verificação de nova versão no repositório do autor original foi desativada (nenhuma chamada de rede). Links de doação (PayPal) e Twitter removidos da janela principal, do menu da bandeja e da aba "Sobre". Links de página/ajuda repontados para este fork.

### Limitação conhecida
As opções de alguns menus suspensos (ex.: gatilho Start/Interval/Stop, botão Left/Right/Middle, direção Up/Down) vêm de enums no código e ainda aparecem em inglês. Pode ser traduzido depois com conversores dedicados.

## Como compilar

Projeto WPF em **.NET Framework 4.7.2**. Requer **Visual Studio 2022** (ou Build Tools) com a carga ".NET desktop development" e restauração de pacotes NuGet.

```
nuget restore "Move Mouse.sln"      # ou restauração automática pelo VS
msbuild "Move Mouse.sln" /p:Configuration=Release
```

O executável sai em `Move Mouse/bin/Release/Move Mouse.exe` (binário único via Costura/Fody).

---

Projeto original © Sean Wheeler, licenciado sob os termos em [LICENSE](LICENSE). Este fork mantém a mesma licença.
