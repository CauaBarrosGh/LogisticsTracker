# 🚚 LogisticsTracker: App de Rastreamento Logístico

Este é um projeto de um aplicativo móvel multiplataforma para rastreamento de pacotes logísticos, desenvolvido com **.NET MAUI**. O foco principal do projeto é a implementação limpa do padrão de arquitetura **MVVM (Model-View-ViewModel)**.

O usuário pode inserir um código de rastreio e visualizar o status, localização atual e histórico completo do seu pacote. Os dados são atualmente simulados por um serviço de "mock" para fins de desenvolvimento.

## ✨ Recursos Principais

* **Padrão MVVM:** Separação clara de responsabilidades usando o `CommunityToolkit.Mvvm` (com `[ObservableProperty]` e `[RelayCommand]`).
* **Busca de Pacotes:** Funcionalidade de entrada de código e busca (simulada).
* **Status Visual Dinâmico:** O status do pacote (ex: "Em Trânsito", "Entregue") muda de cor dinamicamente na UI usando `DataTriggers` no XAML.
* **Histórico em Linha do Tempo:** O histórico de eventos do pacote é exibido em um formato de linha do tempo visual.
* **Interface Reativa:** Uso de um "overlay" de loading que bloqueia a UI e exibe um indicador de atividade durante a busca na rede.
* **Design Centralizado:** Estilos globais para botões, frames (cartões) e cores definidos no `App.xaml` para garantir consistência visual.
* **Injeção de Dependência (DI):** Registro de ViewModels e Serviços no `MauiProgram.cs` para um código desacoplado e testável.

## 🛠️ Arquitetura e Tecnologias

* **.NET MAUI:** Framework multiplataforma da Microsoft para Android, iOS, Windows e macOS.
* **XAML:** Linguagem de marcação declarativa para a construção da interface do usuário.
* **C#:** Linguagem de programação para toda a lógica de negócios e ViewModels.
* **MVVM (Model-View-ViewModel):** Padrão de arquitetura principal do projeto.
* **CommunityToolkit.Mvvm:** Biblioteca utilizada para simplificar a implementação do MVVM.
* **CommunityToolkit.Maui:** Biblioteca de helpers para .NET MAUI.
* **Injeção de Dependência:** Utilizando o container de DI nativo do `.NET`.

## 📂 Estrutura do Projeto

O projeto está organizado seguindo as melhores práticas do MVVM:

* **/Models:** Contém as classes de dados puras que representam a lógica de negócios.
    * `PackageInfo.cs`: Representa o pacote completo.
    * `TrackingEvent.cs`: Representa um único evento no histórico.
* **/ViewModels:** Contém a lógica de apresentação e o estado da UI.
    * `MainViewModel.cs`: Lógica da página de busca.
    * `PackageDetailsViewModel.cs`: Lógica da página de resultados e recebimento de parâmetros de navegação.
* **/Views:** Contém as páginas da UI (XAML e code-behind).
    * `MainPage.xaml`: Tela de entrada do código de rastreio.
    * `PackageDetailsPage.xaml`: Tela de exibição dos resultados.
* **/Services:** Contém a lógica de negócios e acesso a dados (APIs, banco de dados, etc.).
    * `ITrackingService.cs`: Interface que define o contrato do serviço.
    * `MockTrackingService.cs`: Implementação "fake" que simula uma chamada de API.
* **App.xaml:** Define os estilos globais e a paleta de cores do aplicativo.
* **MauiProgram.cs:** Ponto de entrada do app, onde os serviços e ViewModels são registrados para Injeção de Dependência.

## 🚀 Como Executar

1.  Clone este repositório: `git clone https://https://github.com/CauaBarrosGh/LogisticsTracker`
2.  Abra a solução `LogisticsTracker.sln` no Visual Studio 2022 (ou superior).
3.  Restaure os pacotes NuGet (deve ser automático).
4.  Selecione o dispositivo desejado (Emulador Android, iPhone local, etc.).
5.  Pressione **F5** ou clique em "Executar" para iniciar o aplicativo.

### Códigos de Teste

Para testar o serviço mockado, utilize os seguintes códigos na tela de busca:
* `BR12345` (Pacote em trânsito)
* `US98765` (Pacote entregue)
* Qualquer outro código (ex: `AAAAAAAA`) retornará um erro de "não encontrado".
