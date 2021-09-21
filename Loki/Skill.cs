using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Loki
{
    public class Skill : INotifyPropertyChanged
    {
        private float _level;
        private float _accumulator;

        public Skill(SkillType type, float level, float accumulator)
        {
            Type = type;
            SkillName = GetSkillName(type);
            Level = level;
            Accumulator = accumulator;
        }

        private static string GetSkillName(SkillType type)
            =>
                type switch
                {
                    SkillType.None => Properties.Resources.None,
                    SkillType.Swords => Properties.Resources.Swords,
                    SkillType.Knives => Properties.Resources.Knives,
                    SkillType.Clubs => Properties.Resources.Clubs,
                    SkillType.Polearms => Properties.Resources.Polearms,
                    SkillType.Spears => Properties.Resources.Spears,
                    SkillType.Blocking => Properties.Resources.Blocking,
                    SkillType.Axes => Properties.Resources.Axes,
                    SkillType.Bows => Properties.Resources.Bows,
                    SkillType.FireMagic => Properties.Resources.FireMagic,
                    SkillType.FrostMagic => Properties.Resources.FrostMagic,
                    SkillType.Unarmed => Properties.Resources.Unarmed,
                    SkillType.Pickaxes => Properties.Resources.Pickaxes,
                    SkillType.WoodCutting => Properties.Resources.Wood_Cutting,
                    SkillType.Jump => Properties.Resources.Jump,
                    SkillType.Sneak => Properties.Resources.Sneak,
                    SkillType.Run => Properties.Resources.Run,
                    SkillType.Swim => Properties.Resources.Swim,
                    SkillType.Ride => Properties.Resources.Riding,
                    SkillType.All => Properties.Resources.All,
                    _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unrecognised skill type"),
                };

        public SkillType Type { get; }
        public string SkillName { get; }

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
