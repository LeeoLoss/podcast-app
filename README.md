# 📘 PodcastApp

Um projeto simples em *C# (.NET)* demonstrando princípios de *orientação a objetos* através de três classes principais:

- Program.cs — ponto de entrada da aplicação  
- Podcast.cs — representa um podcast  
- Episodio.cs — representa um episódio  

---

## 🎯 Objetivo

O *PodcastApp* foi criado para demonstrar:

- Estrutura de um projeto C# orientado a objetos  
- Composição entre classes (Podcast possui Episódios)  
- Encapsulamento e organização de código  
- Uso básico do .NET em aplicações de console  

---

## 📁 Estrutura do Projeto


PodcastApp/
│
├── Program.cs        # Classe principal / execução
├── Podcast.cs        # Classe que representa um podcast
└── Episodio.cs       # Classe que representa um episódio


---

## 🧩 Descrição das Classes

### 🔹 Episodio.cs  
Define um episódio com:
- Título  
- Duração em minutos  
- Convidado  

---

### 🔹 Podcast.cs  
Representa um podcast contendo:
- Nome  
- Host  
- Lista interna de episódios  
- Método AddEpisodio()  
- Método ListarEpisodios()  

---

### 🔹 Program.cs  
Cria objetos Podcast e Episodio, adiciona episódios e exibe os detalhes no console.

---

## ▶️ Como Executar

1. Clone o repositório:
   bash
   git clone https://github.com/SEU-USUARIO/PodcastApp.git
   

2. Acesse o diretório:
   bash
   cd PodcastApp
   

3. Execute:
   bash
   dotnet run
   

---

## 🛠 Tecnologias Utilizadas

- C#  
- .NET (versão definida no .csproj)  
- Git e GitHub  

---

## 📄 Licença

Este projeto é livre para uso educacional.  
Adicione uma licença específica caso deseje.

---

## 💡 Possíveis Melhorias Futuras

- Persistência dos dados em JSON ou banco de dados  
- Interface interativa  
- API Web com ASP.NET  
- Interface gráfica com MAUI ou WinForms
