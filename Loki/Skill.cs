using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Loki
{
    public class Skill: INotifyPropertyChanged
    {
        private float _level;
        private float _accumulator;

        public Skill(SkillType type, float level, float accumulator)
        {
            Type = type;
            Level = level;
            Accumulator = accumulator;
        }

        public SkillType Type { get; }

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
