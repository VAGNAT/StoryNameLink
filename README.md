# StoryNameLink
### Instructions for building and running the application:
An installed MSSQL server is required to run the application. Also in the application there is test data.
### Brief description of the approach to solving the problem
Used Blazor.server. Created one page. Used MSSQL database. Created four levels of application architecture:
1. Domain level with entities and interfaces of repositories.
2. Infrastructure layer with connected EntityFramework. Provides CRUD operations.
3. The level of services for processing business logic.
4. The Blazor.server project itself for the user interface.
This will prepare the project for future expansion.
### Trade-offs and areas for improvement.
1. One of the trade-offs is the lack of real-time collaboration or simultaneous editing by multiple users. The application is currently single-user focused and does not handle concurrent changes by multiple users.
2. The app does not provide authentication and authorization features. Adding user authentication would be useful for managing user accounts and securely accessing stories.
3. The current implementation does not include error handling and user input validation. It is important to add appropriate error handling and validation to ensure data integrity and improve user experience.
4. Lack of unit, integration and functional testing.
5. Further optimizations can be made to improve performance, such as implementing caching mechanisms to reduce database queries and optimizing the parsing logic for large histories.
6. Improve character name detection algorithm to handle more complex cases.
7. Implement a more complex color generation algorithm.

# StoryNameLink
### Инструкция по сборке и запуску приложения:
Для запуска приложения необходим установленный MSSQL сервер. Так же в приложении есть тестовые данные.
### Краткое описание подхода к решению задачи
Использовал Blazor.server. Создал одну страницу. Использовал базу данных MSSQL. Создал четыре уровня архитектуры приложения:
1. Уровень домена с сущностями и интерфейсами репозиториев.
2. Уровень инфраструктуры с подключенным EntityFramework. Предоставляет CRUD операции.
3. Уровень сервисов для обработки бизнес-логики.
4. Сам проект Blazor.server для пользовательского интерфейса.
Так проект будет подготовлен для будущего расширения.
### Компромиссы и области для улучшения.
1. Одним из компромиссов является отсутствие совместной работы в реальном времени или одновременного редактирования несколькими пользователями. В настоящее время приложение ориентировано на одного пользователя и не обрабатывает одновременные изменения несколькими пользователями.
2. Приложение не предоставляет функции проверки подлинности и авторизации. Добавление аутентификации пользователей было бы полезно для управления учетными записями пользователей и безопасного доступа к историям.
3. Текущая реализация не включает обработку ошибок и проверку пользовательского ввода. Важно добавить соответствующую обработку ошибок и проверку, чтобы обеспечить целостность данных и улучшить взаимодействие с пользователем.
4. Отсутствие модульного, интеграционного и функционального тестирования.
5. Для повышения производительности может быть выполнена дальнейшая оптимизация, например внедрение механизмов кэширования для сокращения запросов к базе данных и оптимизация логики синтаксического анализа для больших историй.
6. Улучшить алгоритм определения имени персонажа для обработки более сложных случаев.
7. Реализовать более сложный алгоритм генерации цвета.
