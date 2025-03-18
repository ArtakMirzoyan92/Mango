************************************************************************  Eng  ********************************************************************************

E-Commerce Microservices Application with .NET 6

This project showcases the development of a microservices-based e-commerce application using .NET 6. 
It follows clean architecture principles and demonstrates a step-by-step approach to building modular, scalable microservices.

🏗 Project Overview:
Microservices Architecture: Independent services handling core functionalities such as product management, shopping cart, ordering, payments, and email notifications.
Authentication & Authorization: Implemented with .NET Identity for secure user management.
Communication: Microservices interact via Azure Service Bus, ensuring reliable message delivery.
API Gateway: Ocelot handles request routing and aggregation.
Data Access: Uses Entity Framework Core with SQL Server for data persistence.
⚙️ Microservices Included:
Product Microservice — Manages product catalog.
Identity Microservice — Handles user authentication and authorization.
Coupon Microservice — Applies discount coupons to orders.
Shopping Cart Microservice — Manages shopping cart functionality.
Order Microservice — Processes and tracks orders.
Email Microservice — Sends email notifications.
Payment Microservice — Handles payment processing.
Ocelot API Gateway — Routes requests between services.
MVC Web Application — Provides a user-friendly interface.

************************************************************************  Рус  ********************************************************************************

Приложение микросервисной архитектуры для электронной коммерции на .NET 6

Этот проект демонстрирует разработку приложения электронной коммерции на основе микросервисов с использованием .NET 6. 
Он следует принципам чистой архитектуры и показывает пошаговый подход к созданию модульных и масштабируемых микросервисов.

🏗 Обзор проекта:

Архитектура микросервисов: Независимые сервисы, обрабатывающие ключевые функции, такие как управление продуктами, корзина покупок, оформление заказов, платежи и отправка email-уведомлений.
Аутентификация и авторизация: Реализована с помощью .NET Identity для безопасного управления пользователями.
Взаимодействие микросервисов: Осуществляется через Azure Service Bus, обеспечивая надежную доставку сообщений.
API-шлюз: Ocelot управляет маршрутизацией запросов и их агрегацией.
Доступ к данным: Используется Entity Framework Core с SQL Server для хранения данных.
⚙️ Включенные микросервисы:
Продуктовый микросервис — Управляет каталогом продуктов.
Микросервис идентификации — Обрабатывает аутентификацию и авторизацию пользователей.
Купонный микросервис — Применяет скидочные купоны к заказам.
Микросервис корзины покупок — Управляет функциональностью корзины.
Микросервис заказов — Обрабатывает и отслеживает заказы.
Микросервис email-уведомлений — Отправляет уведомления по электронной почте.
Микросервис платежей — Обрабатывает платежные операции.
Ocelot API Gateway — Маршрутизирует запросы между сервисами.
Веб-приложение MVC — Обеспечивает удобный пользовательский интерфейс.
