﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MumbleDB;

public partial class _240415CabadingProj1Context : DbContext
{
    public _240415CabadingProj1Context()
    {
    }

    public _240415CabadingProj1Context(DbContextOptions<_240415CabadingProj1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Messages__C87C0C9C2E13BC06");

            entity.Property(e => e.FromUserId).HasColumnName("FromUserID");
            entity.Property(e => e.Message1)
                .HasMaxLength(150)
                .HasColumnName("Message");
            entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

            entity.HasOne(d => d.FromUser).WithMany(p => p.MessageFromUsers)
                .HasForeignKey(d => d.FromUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Messages__FromUs__628FA481");

            entity.HasOne(d => d.ToUser).WithMany(p => p.MessageToUsers)
                .HasForeignKey(d => d.ToUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Messages__ToUser__6383C8BA");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C4F8167F5");

            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Password).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
