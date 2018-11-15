//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System.IO;

namespace Microsoft.CognitiveServices.Speech.Tests.EndToEnd
{
    static class TestData
    {
        public static string AudioDir { get; set; }

        public static class German
        {
            public static class Batman
            {
                public static readonly string[] Utterances =
                {
                    "Fähigkeiten und Fähigkeiten Batman hat keine inhärenten Superkräfte. Er setzt auf seine eigenen wissenschaftlichen Kenntnisse Detektiv-Fähigkeiten und sportliche Geschicklichkeit in den Geschichten Batman gilt als einer der größten Detektiv der Welt, wenn nicht der weltweit größte Verbrecher Löser Batman wurde immer wieder beschrieben.",
                    "Diesem Niveau.",
                    "Einer der größten Kampfkünstler im DC-Universum und mit höchster menschlicher körperlicher Konditionierung. Er hat die Welt bereist, um die Fähigkeiten zu erwerben, die nötig sind, um seinem Kreuzzug zu helfen. sein Wissen und seine Expertise in fast jeder Disziplin, die dem Menschen bekannt ist, ist von keinem anderen Charakter in einzig",
                    "Bat man es unerschöpflichen Reichtum ermöglicht es ihm, auf fortschrittliche Technologie zuzugreifen, da ein kompetenter Wissenschaftler in der Lage ist, diese Technologien zu seinem Vorteil zu nutzen und zu modifizieren. Batman beschreibt Superman als den gefährlichsten Mann der Erde, der in der Lage ist, ein Team von. Super powered extra.",
                    "Von sich aus, um seine inhaftierten Teamkollegen zu retten.",
                    "In der ersten Storyline hält Superman auch Batman für einen der brillantesten Köpfe auf dem Planeten.",
                    "Batman hat die Fähigkeit, unter großen körperlichen Schmerzen zu funktionieren und der Gedankenkontrolle zu widerstehen. Er ist ein Meister der Verkleidung mehrsprachig und ein Experte in der Spionage oft sammeln Informationen unter verschiedenen Identität bat man es Karate judo.",
                    "Die Ausbildung hat ihn nach dem Meister der Verstohlenheit zu einer Flucht gemacht, die es ihm erlaubt, nach Willen zu erscheinen und zu verschwinden und sich zu befreien."
                };
            }

            public static class HowIsYourWork
            {
                public const string Utterance = "Wie machen Sie heute mit den Arbeitsstücken";
            }

            public static class Weather
            {
                public static readonly string Utterance = "Wie ist das Wetter?";
            }

            public static class FirstOne
            {
                public static readonly string AudioFile = Path.Combine(AudioDir, "CallTheFirstOne.wav");
                public static readonly string Utterance = "Rufe die erste an.";
            }
        }

        public static class Chinese
        {
            public static class Weather
            {
                public static readonly string Utterance = "天气怎么样？";
            }
        }

        public static class English
        {
            public static class Margarita
            {
                public static readonly string AudioFile = Path.Combine(AudioDir, "Margarita-44100.wav");
                public static readonly string[] Utterance =
                {
                    "Second, now and Love, a margarita and if you're anything like me, you probably had your fair share and if you have. You've probably noticed that margaritas can vary from incredible 2?",
                    "Earth so I'm going to show you how to make one of those incredibly fresh and Delicious Margaritas. There are 3 key steps you need to follow first."
                };
            }

            public static class Batman
            {
                public static readonly string AudioFile = Path.Combine(AudioDir,"batman.wav");
                // This is expected results using StartContinuousRecognitionAsync() which uses converstation mode.
                // The result using RecognizeOnceAsync() might be slightly different, since it uses interactive mode.
                public static readonly string[] Utterances =
                {
                    "Skills and abilities Batman has no inherent super powers. He relies on his own scientific knowledge detective skills and athletic prowess in the stories batman is regarded as one of the world's greatest detective if not the world's Greatest Crime Solver Batman has been repeatedly described.",
                    "This level.",
                    "One of the greatest martial artists in the DC universe and having peak human physical conditioning. He has traveled the world acquiring the skills needed to aid his crusade grounds crime his knowledge and expertise in almost every discipline known to man is nearly unparalleled by any other character in the",
                    "Bat man's inexhaustible wealth allows him to access advanced technology as a proficient scientists use able to use and modify those technologies to his advantage Batman describes superman as the most dangerous man on earth able to defeat a team of. Super powered extra.",
                    "By himself in order to rescue his imprisoned teammates.",
                    "In the first storyline superman also considers batman to be one of the most brilliant minds on the planet.",
                    "Batman has the ability to function under great physical pain and withstand mind control. He is a master of disguise multilingual and an expert in espionage often gathering information under different identity's bat man's karate judo.",
                    "To training has made him after master of stealth an escape allowing tumor allowing him to appear and disappear at will and to break free."
                };

                public static readonly string[] Utterances2 =
                {
                    "Skills and abilities Batman has no inherent super powers. He relies on his own scientific knowledge detective skills and athletic prowess in the stories batman is regarded as one of the world's greatest detective if not the world's Greatest Crime Solver Batman has been repeatedly described.",
                    "Nice level.",
                    "One of the greatest martial artists in the DC universe and having peak human physical conditioning. He has traveled the world acquiring the skills needed to aid his crusade grounds crime his knowledge and expertise in almost every discipline known to man is nearly unparalleled by any other character in the",
                    "Bat man's inexhaustible wealth allows him to access advanced technology as a proficient scientists use able to use and modify those technologies to his advantage Batman describes superman as the most dangerous man on earth able to defeat a team of. Super powered extra.",
                    "By himself in order to rescue his imprisoned teammates.",
                    "In the first storyline superman also considers batman to be one of the most brilliant minds on the planet.",
                    "Batman has the ability to function under great physical pain and withstand mind control. He is a master of disguise multilingual and an expert in espionage often gathering information under different identity's bat man's karate judo.",
                    "To training has made him after master of stealth an escape allowing tumor allowing him to appear and disappear at will and to break free."
                };
            }

            public static class Weather
            {
                public static readonly string AudioFile = Path.Combine(AudioDir, "whatstheweatherlike.wav");
                public static readonly string Utterance = "What's the weather like?";
            }

            public static class Silence
            {
                public static readonly string AudioFile = Path.Combine(AudioDir, "silenceshort.wav");
            }
            public static class HomeAutomation
            {
                public static class TurnOn
                {
                    public static readonly string AudioFile = Path.Combine(AudioDir, "TurnOnTheLamp.wav");
                    public static readonly string Utterance = "Turn on the lamp.";
                }
                public static class TurnOff
                {
                    public static readonly string AudioFile = Path.Combine(AudioDir, "ShutDownTheComputer.wav");
                    public static readonly string Utterance = "Shut down the computer.";
                }
            }
        }

        public static class French
        {
            public static class Batman
            {
                public static readonly string[] Utterances =
                {
                    "Compétences et aptitudes Batman n'a pas de super pouvoirs inhérents. Il s'appuie sur ses propres connaissances scientifiques des compétences de détective et des prouesses athlétiques."
                };
            }
        
            public static class FirstOne
            {
                public static readonly string Utterance = "Appelle le premier.";
            }

            public static class Weather
            {
                public static readonly string Utterance = "Quel temps fait-il?";
            }
        }

        public static class Spanish
        {
            public static class Batman
            {
                public static readonly string[] Utterances =
                {
                    "Habilidades y habilidades Batman no tiene súper poderes inherentes. Se basa en su propio conocimiento científico habilidades de detective y destreza atlética."
                };
            }

            public static class FirstOne
            {
                public static readonly string Utterance = "Llama al primero.";
            }

            public static class Weather
            {
                public static readonly string Utterance = "¿Cómo es el clima?";
            }
        }

        public static class Catalan
        {
            public static readonly string AudioFile = Path.Combine(AudioDir, "ca-es.wav");

            public static class HowIsYourWork
            {
                public static readonly string Utterance = @"Com estàs fent amb els elements de treball avui";
            }

            public static class Weather
            {
                public static readonly string Utterance = "Wie ist das Wetter?";
            }

            public static class FirstOne
            {
                public static readonly string AudioFile = Path.Combine(AudioDir, "CallTheFirstOne.wav");
                public static readonly string Utterance = "Rufe die erste an.";
            }
        }
    }
}