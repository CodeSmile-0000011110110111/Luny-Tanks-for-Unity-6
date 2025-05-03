using CodeSmile.Luny.Tanks;
using UnityEditor;

namespace CodeSmile.Luny.Tanks
{
    [CustomEditor(typeof(LunyPowerUp))]
    public class LunyPowerUpEditor : Editor
    {
        SerializedProperty powerUpType;
        SerializedProperty durationTime;
        SerializedProperty collectFX;
        SerializedProperty speedBonus, turnSpeedBonus;
        SerializedProperty damageReduce;
        SerializedProperty cooldownReduction;
        SerializedProperty healingAmount;
        SerializedProperty damageMultiplier;

        private void OnEnable()
        {
            // gets references of the fields
            powerUpType = serializedObject.FindProperty("m_PowerUpType");
            durationTime = serializedObject.FindProperty("m_DurationTime");
            collectFX = serializedObject.FindProperty("m_CollectFX");
            speedBonus = serializedObject.FindProperty("m_SpeedBonus");
            turnSpeedBonus = serializedObject.FindProperty("m_TurnSpeedBonus");
            damageReduce = serializedObject.FindProperty("m_DamageReduction");
            cooldownReduction = serializedObject.FindProperty("m_CooldownReduction");
            healingAmount = serializedObject.FindProperty("m_HealingAmount");
            damageMultiplier = serializedObject.FindProperty("m_DamageMultiplier");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            // Shows the power up type and duration time
            EditorGUILayout.PropertyField(powerUpType);
            EditorGUILayout.PropertyField(collectFX);

            // Shows  the fields of the selected type
            LunyPowerUp.PowerUpType selectedType = (LunyPowerUp.PowerUpType)powerUpType.enumValueIndex;

            switch (selectedType)
            {
                case LunyPowerUp.PowerUpType.Speed:
                    EditorGUILayout.PropertyField(durationTime);
                    EditorGUILayout.PropertyField(speedBonus);
                    EditorGUILayout.PropertyField(turnSpeedBonus);
                    break;

                case LunyPowerUp.PowerUpType.DamageReduction:
                    EditorGUILayout.PropertyField(durationTime);
                    EditorGUILayout.PropertyField(damageReduce);
                    break;

                case LunyPowerUp.PowerUpType.ShootingBonus:
                    EditorGUILayout.PropertyField(durationTime);
                    EditorGUILayout.PropertyField(cooldownReduction);
                    break;

                case LunyPowerUp.PowerUpType.Healing:
                    EditorGUILayout.PropertyField (healingAmount);
                    break;

                case LunyPowerUp.PowerUpType.DamageMultiplier:
                    EditorGUILayout.PropertyField(damageMultiplier);
                    break;
                case LunyPowerUp.PowerUpType.Invincibility:
                    EditorGUILayout.PropertyField(durationTime); 
                    break;
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
