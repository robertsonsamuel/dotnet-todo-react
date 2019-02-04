﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoApp.Models;

namespace TodoApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20190203144624_AddTodoLists")]
    partial class AddTodoLists
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TodoApp.AspNetCore.Models.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TodoBody");

                    b.Property<int>("TodoListId");

                    b.HasKey("TodoId");

                    b.HasIndex("TodoListId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("TodoApp.AspNetCore.Models.TodoList", b =>
                {
                    b.Property<int>("TodoListId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("TodoListId");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("TodoApp.AspNetCore.Models.Todo", b =>
                {
                    b.HasOne("TodoApp.AspNetCore.Models.TodoList", "TodoList")
                        .WithMany("Todos")
                        .HasForeignKey("TodoListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
