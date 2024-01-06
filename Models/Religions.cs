using System.Collections.Generic;

namespace Rollbard.Library.Models
{
    public static class Religions
    {
        public static Religion Catholicism { get; } = new Religion
        {
            Name = nameof(Catholicism),
            ClericTitles = new List<Title>
            {
                new Title("Priest", "Father"),
                new Title("Bishop"),
                new Title("Nun", "Sister"),
                new Title("Cardinal"),
                new Title("Archbishop"),
            },
            Deities = new List<Deity>
            {
                new Deity
                {
                    IsSupreme = true,
                    Name = "God",
                    Domain = "Everything"
                }
            },
            CreationMyth = "In the beginning God created the heavens and the earth",
            DeityType = DeityType.Monotheistic,
            Creatures = new List<MysticalCreature>
            {
                new MysticalCreature
                {
                    Name = "Lucifer",
                    Alignment = Alignment.Evil,
                    Description = "Lord of Hell.  First of the Fallen"
                }
            },
            LeaderTitle = new Title("Pope"),
            ImportantFigures = new List<ReligiousFigure>
            {
                new ReligiousFigure
                {
                    Name = "Jesus Christ",
                    Title = "Messiah",
                    ReligiousFigureType = ReligiousFigureType.Demigod
                },
                new ReligiousFigure
                {
                    Name = "Saint Mary",
                    Title = "Mother of Jesus",
                    ReligiousFigureType = ReligiousFigureType.Prophet
                },
            },
            HolyBook = "Bible"
        };

        public static Religion Islam { get; } = new Religion
        {
            Name = nameof(Islam),
            ClericTitles = new List<Title>
            {
                new Title("Imam"),
                new Title("Sheikh"),
            },
            Deities = new List<Deity>
            {
                new Deity
                {
                    IsSupreme = true,
                    Name = "Allah",
                    Domain = "Everything"
                }
            },
            CreationMyth = "The heavens and the earth were joined together as one unit",
            DeityType = DeityType.Monotheistic,
            Creatures = new List<MysticalCreature>
            {
                new MysticalCreature
                {
                    Name = "Iblis",
                    Alignment = Alignment.Evil,
                    Description = "Leader of devils"
                }
            },
            LeaderTitle = new Title("Grand Imam"),
            ImportantFigures = new List<ReligiousFigure>
            {
                new ReligiousFigure
                {
                    Name = "Muhammad",
                    Title = "The Prophet",
                    ReligiousFigureType = ReligiousFigureType.Prophet
                },
            },
            HolyBook = "Quran"
        };

        public static Religion Protestantism { get; } = new Religion
        {
            Name = nameof(Protestantism),
            ClericTitles = new List<Title>
            {
                new Title("Pastor"),
                new Title("Preacher", "Elder"),
                new Title("Preacher", "Brother"),
                new Title("Minister", "Brother"),
            },
            Deities = new List<Deity>
            {
                new Deity
                {
                    IsSupreme = true,
                    Name = "God",
                    Domain = "Everything"
                }
            },
            CreationMyth = "In the beginning God created the heavens and the earth",
            DeityType = DeityType.Monotheistic,
            Creatures = new List<MysticalCreature>
            {
                new MysticalCreature
                {
                    Name = "Lucifer",
                    Alignment = Alignment.Evil,
                    Description = "Lord of Hell.  First of the Fallen"
                }
            },
            LeaderTitle = new Title("Bishop"),
            ImportantFigures = new List<ReligiousFigure>
            {
                new ReligiousFigure
                {
                    Name = "Jesus Christ",
                    Title = "Messiah",
                    ReligiousFigureType = ReligiousFigureType.Demigod
                }
            },
            HolyBook = "Bible"
        };

        public static IEnumerable<Religion> GetAll() => new List<Religion>() {
            Protestantism,
            Catholicism,
            Islam
        };
    }
}