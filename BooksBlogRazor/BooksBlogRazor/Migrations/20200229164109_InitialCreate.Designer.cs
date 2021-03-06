﻿// <auto-generated />
using System;
using BooksBlogRazor.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BooksBlogRazor.Migrations
{
    [DbContext(typeof(BooksBlogDbContext))]
    [Migration("20200229164109_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksBlogRazor.Persistence.Models.BookReview", b =>
                {
                    b.Property<int>("BookReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Genre")
                        .HasMaxLength(255);

                    b.Property<string>("Image");

                    b.Property<int?>("MyRating");

                    b.Property<string>("Review");

                    b.Property<DateTime?>("ReviewDateCreated");

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.HasKey("BookReviewId");

                    b.ToTable("BookReviews");

                    b.HasData(
                        new
                        {
                            BookReviewId = 1,
                            Description = "Капитан Джон Миллер получает тяжелое задание. Вместе с отрядом из восьми человек Миллер должен отправиться в тыл врага на поиски рядового Джеймса Райана, три родных брата которого почти одновременно погибли на полях сражений",
                            Genre = "Action",
                            Image = "https://www.kinopoisk.ru/images/film_big/371.jpg",
                            MyRating = 5,
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Спасти рядового Райана"
                        },
                        new
                        {
                            BookReviewId = 2,
                            Description = "Семнадцатилетняя девушка Белла переезжает к отцу в небольшой городок Форкс. Она влюбляется в загадочного одноклассника, который, как оказалось, происходит из семьи вампиров, отказавшихся от нападений на людей. Влюбиться в вампира. Это страшно? Это романтично, это прекрасно и мучительно, но это не может кончиться добром, особенно в вечном противостоянии вампирских кланов, где малейшее отличие от окружающих уже превращает вас во врага.",
                            Genre = "Drama",
                            Image = "https://www.kinopoisk.ru/images/film_big/401177.jpg",
                            MyRating = 3,
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Сумерки"
                        },
                        new
                        {
                            BookReviewId = 3,
                            Description = "Миллиардер-изобретатель Тони Старк попадает в плен к Афганским террористам, которые пытаются заставить его создать оружие массового поражения. В тайне от своих захватчиков Старк конструирует высокотехнологичную киберброню, которая помогает ему сбежать. Однако по возвращении в США он узнаёт, что в совете директоров его фирмы плетётся заговор, чреватый страшными последствиями. Используя своё последнее изобретение, Старк пытается решить проблемы своей компании радикально…",
                            Genre = "Action",
                            Image = "https://www.kinopoisk.ru/images/film_big/61237.jpg",
                            MyRating = 4,
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Железный Человек"
                        },
                        new
                        {
                            BookReviewId = 4,
                            Description = "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви. Но вместо этого герой попадает в эпицентр больших неприятностей.Сделав ставку на подпольном боксерском поединке,Френки попадает в круговорот весьма нежелательных событий.",
                            Genre = "Criminal",
                            Image = "https://www.kinopoisk.ru/images/film_big/526.jpg",
                            MyRating = 5,
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Большой куш"
                        },
                        new
                        {
                            BookReviewId = 5,
                            Description = "Дрю Деккер разговаривает по телефону с незнакомцем, будто бы попавшим не туда. Очень скоро она понимает, что её собеседник — маньяк, который хочет её убить. Дрю выбегает из дома, по пятам преследуемая маньяком. Девушке почти удаётся убежать, но её случайно сбивает машина отца…",
                            Genre = "Comedy",
                            Image = "https://www.kinopoisk.ru/images/film_big/5932.jpg",
                            MyRating = 2,
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Очень страшное кино"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
