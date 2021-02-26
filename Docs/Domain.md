### Bounded Contexts

### Aggregates

### Proposed item grouping
[CharacterProfile]

CharacterName |
Class |
Background |
Race |
Alignment |
Age |
Height |
Weight |
Eyes |
Skin |
Hair |
ProfilePicture |


[Attributes]

Strength |
StrengthMod |
Dexterity |
DexterityMod |
Constitution |
ConstitutionMod |
Intelligence |
IntelligenceMod |
Wisdom |
WisdomMod |
Charisma |
CharismaMod |


[Skills]

// Should these be KVPs? k: int skillName, v: bool proficient

Acrobatics |
AnimalHandling |
Arcana |
Athletics |
Deception |
History |
Insight |
Intimidation |
Investigation |
Medicine |
Nature |
Perception |
Performance |
Persuasion |
Religion |
SleightOfHand |
Stealth |
Survival |

passivePerception..? 


[SavingThrows]

// Should these be KVPs? k: int savingThrow, v: bool proficient

Strength |
Dexterity |
Constitution |
Intelligence |
Wisdom |
Charisma |

