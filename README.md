# API-Produto
# 🖥️ Backend .NET - Documentação

## 📌 Descrição do Projeto
Este backend foi desenvolvido em **.NET 8** para fornecer uma API escalável, organizada e de fácil manutenção.  
A arquitetura segue princípios de **Clean Architecture** e **SOLID**, garantindo qualidade no código e flexibilidade para evolução futura.

---

## 🔑 Boas Práticas e Padrões Aplicados
- **SOLID**: código modular e organizado, facilitando manutenção.  
- **Dependency Injection (DI)**: desacoplamento entre camadas.  
- **Repository Pattern**: abstração do acesso ao banco de dados.  
- **DTOs + AutoMapper**: separação entre entidades do banco e dados de entrada/saída.   
- **Swagger**: documentação interativa da API.

---

## 🧩 Demonstração de SOLID Aplicado
- **S - Single Responsibility Principle:** cada classe cumpre apenas uma função.  
- **O - Open/Closed Principle:** o sistema é extensível sem alterar código existente.  
- **L - Liskov Substitution Principle:** classes podem ser substituídas por outras implementações sem quebrar a aplicação.  
- **I - Interface Segregation Principle:** interfaces pequenas e específicas.  
- **D - Dependency Inversion Principle:** serviços dependem de abstrações, não de implementações concretas.

---

### Produtos
| Método | Endpoint | Descrição |
|--------|----------|-----------|
| **POST** | `/api/produtos` | Cria um novo produto |
| **GET** | `/api/produtos` | Lista todos os produtos |
| **DELETE** | `/api/produtos/{id}` | Remove um produto |
| **PUT** | `/api/produtos/{id}` | Atualiza um produto existente |

<img width="1918" height="1016" alt="image" src="https://github.com/user-attachments/assets/2ff4dd9c-98a6-4737-80cb-66120bf52cd3" />

---

## 🛠️ Tecnologias Utilizadas
- **.NET 8 / ASP.NET Core Web API**  
- **Entity Framework Core**  
- **AutoMapper**  
- **FluentValidation**  
- **Swagger**

---

## 💡 Observações
- Estrutura modular facilita manutenção e inclusão de novas funcionalidades.  
- Todos os endpoints seguem padrão RESTful e retornam códigos HTTP apropriados.  
- Pode ser integrado facilmente com frontend React, Angular ou outras aplicações.

