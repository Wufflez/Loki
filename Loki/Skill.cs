using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Loki
{
    public class Skill: INotifyPropertyChanged
    {
        private string _SkillName;
        private float _level;
        private float _accumulator;

        public Skill(SkillType type, float level, float accumulator)
        {
            Type = type;
            SkillName = Convert.ToString(Type);
            Level = level;
            Accumulator = accumulator;
        }

        public SkillType Type { get; }

        string None = Loki.Properties.Resources.None;
        string Swords = Loki.Properties.Resources.Swords;
        string Knives = Loki.Properties.Resources.Knives;
        string Clubs = Loki.Properties.Resources.Clubs;
        string Polearms = Loki.Properties.Resources.Polearms;
        string Spears = Loki.Properties.Resources.Spears;
        string Blocking = Loki.Properties.Resources.Blocking;
        string Axes = Loki.Properties.Resources.Axes;
        string Bows = Loki.Properties.Resources.Bows;
        string FireMagic = Loki.Properties.Resources.FireMagic;
        string FrostMagic = Loki.Properties.Resources.FrostMagic;
        string Unarmed = Loki.Properties.Resources.Unarmed;
        string Pickaxes = Loki.Properties.Resources.Pickaxes;
        string WoodCutting = Loki.Properties.Resources.WoodCutting;
        string Jump = Loki.Properties.Resources.Jump;
        string Sneak = Loki.Properties.Resources.Sneak;
        string Run = Loki.Properties.Resources.Run;
        string Swim = Loki.Properties.Resources.Swim;
        string All = Loki.Properties.Resources.All;

        public string SkillName
        {
            get => _SkillName;
            set
            {
                if (value.Equals("None")) value = None;
                if (value.Equals("Swords")) value = Swords;
                if (value.Equals("Knives")) value = Knives;
                if (value.Equals("Clubs")) value = Clubs;
                if (value.Equals("Polearms")) value = Polearms;
                if (value.Equals("Spears")) value = Spears;
                if (value.Equals("Blocking")) value = Blocking;
                if (value.Equals("Axes")) value = Axes;
                if (value.Equals("Bows")) value = Bows;
                if (value.Equals("FireMagic")) value = FireMagic;
                if (value.Equals("FrostMagic")) value = FrostMagic;
                if (value.Equals("Unarmed")) value = Unarmed;
                if (value.Equals("Pickaxes")) value = Pickaxes;
                if (value.Equals("WoodCutting")) value = WoodCutting;
                if (value.Equals("Jump")) value = Jump;
                if (value.Equals("Sneak")) value = Sneak;
                if (value.Equals("Run")) value = Run;
                if (value.Equals("Swim")) value = Swim;
                if (value.Equals("All")) value = All;
                _SkillName = value;
            }
        }

        public float Level
        {
            get => _level;
            set
            {
                if (value.Equals(_level)) return;
                if (value <= 0f) value = 0f;
                if (value >= 100f) value = 100f;
                _level = value;
                OnPropertyChanged();
            }
        }

        public float Accumulator
        {
            get => _accumulator;
            set
            {
                if (value.Equals(_accumulator)) return;
                _accumulator = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
