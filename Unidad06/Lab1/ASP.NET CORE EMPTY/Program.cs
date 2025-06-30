using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;
using Alumno;
using Microsoft.AspNetCore.Mvc.Filters;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/alumnos/{id}", (int id) =>
    Alumno.Alumno.Lista.Find(a => a.Id == id) is Alumno.Alumno alumno
        ? Results.Ok(alumno)
        : Results.NotFound());

app.MapPost("/alumnos", (Alumno.Alumno alumno) =>
{
    Alumno.Alumno.Lista.Add(alumno);
    return Results.Created($"/alumnos/{alumno.Id}", alumno);
});

app.MapGet("/alumnos", () =>
    Results.Ok(Alumno.Alumno.Lista));

app.MapPut("/alumnos", (Alumno.Alumno alumno) =>
{
    var al = Alumno.Alumno.Lista.Find(a => a.Id == alumno.Id);
    if (al is null)
        return Results.NotFound();
    al.nombre = alumno.nombre;
    al.apellido = alumno.apellido;
    al.legajo = alumno.legajo;
    al.direccion = alumno.direccion;
    return Results.Ok(al);
});

app.MapDelete("/alumnos/{id}", (int id) =>
{
    var al = Alumno.Alumno.Lista.Find(a => a.Id == id);
    if (al is null)
        return Results.NotFound();
    else
    { 
        Alumno.Alumno.Lista.Remove(al);
        return Results.Ok(al);
    }
});
    

app.Run();