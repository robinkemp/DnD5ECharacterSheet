<template>
  <v-container>
    <v-row class="text-center">
      <v-col cols="12">
        <v-img
          :src="require('../assets/witches-hat.png')"
          class="my-3"
          contain
          height="200"
        />
      </v-col>

      <v-col class="mb-4">
        <h1 class="display-2 font-weight-bold mb-3">
          Welcome to Witches Hat
        </h1>
        <v-row>
          <v-col>
            <v-expansion-panels>
              <v-expansion-panel v-for="spell in spells" v-bind:key="spell">
                <v-expansion-panel-header>
                  {{ spell.name }}
                </v-expansion-panel-header>
                <v-expansion-panel-content>
                  Save: {{ spell.savingThrow }} | Components: {{ spell.verbal ? "V" : "" }} {{ spell.somatic ? "S" : "" }} {{ spell.material ? "M*" : "" }}
                  <v-divider />
                  {{ spell.description }}
                  <v-divider v-if="spell.material"/>
                  {{ spell.components }}
                </v-expansion-panel-content>
              </v-expansion-panel>
            </v-expansion-panels>
          </v-col>
          <v-col />
          <v-col />
        </v-row>
        <p class="subheading font-weight-regular">
          For help and collaboration with other witches,
          <br />please join our online
          <a href="javascript: alert('Hello impatient')">Discord Community</a
          >
        </p>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "HelloWitches",

  data: () => ({
    spells:[
      {
        name:"Fire Ball", 
        description:"A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot-radius sphere centered on that point must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed save, or half as much damage on a successful one. The fire spreads around corners. It ignites flammable objects in the area that aren't being worn or carried. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, the damage increases by 1d6 for each slot level above 3rd.", 
        savingThrow:"CON", 
        verbal:true,
        somatic:true,
        material:true,
        components: "*a tiny ball of bat guano and sulfur"
      },
      {
        name:"Frostbite", 
        description:"You cause numbing frost to form on one creature that you can see within range. The target must make a Constitution saving throw. On a failed save, the target takes 1d6 cold damage, and it has disadvantage on the next weapon attack roll it makes before the end of its next turn. The spell’s damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6).", 
        savingThrow:"CON", 
        verbal:true,
        somatic:true,
        material:false,
        components:""
      },
      {
        name:"Thunderwave",
        description:"A wave of thunderous force sweeps out from you. Each creature in a 15-foot cube originating from you must make a Constitution saving throw. On a failed save, a creature takes 2d8 thunder damage and is pushed 10 feet away from you. On a successful save, the creature takes half as much damage and isn't pushed. In addition, unsecured objects that are completely within the area of effect are automatically pushed 10 feet away from you by the spell's effect, and the spell emits a thunderous boom audible out to 300 feet. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.", 
        savingThrow:"CON", 
        verbal:true,
        somatic:true,
        material:false,
        components: ""
      },
      {
        name:"Shatter",
        description:"A sudden loud ringing noise, painfully intense, erupts from a point of your choice within range. Each creature in a 10-foot-radius sphere centered on that point must make a Constitution saving throw. A creature takes 3d8 thunder damage on a failed save, or half as much damage on a successful one. A creature made of inorganic material such as stone, crystal, or metal has disadvantage on this saving throw. A nonmagical object that isn’t being worn or carried also takes the damage if it’s in the spell’s area. At Higher Levels: When you cast this spell using a spell slot of or higher, the damage increases by 1d8 for each slot level above 2nd.", 
        savingThrow:"CON", 
        verbal:true,
        somatic:true,
        material:true,
        components: "*a chip of mica"
      }
    ],
    ecosystem: [
      {
        text: "vuetify-loader",
        href: "https://github.com/vuetifyjs/vuetify-loader"
      },
      {
        text: "github",
        href: "https://github.com/vuetifyjs/vuetify"
      },
      {
        text: "awesome-vuetify",
        href: "https://github.com/vuetifyjs/awesome-vuetify"
      }
    ],
    importantLinks: [
      {
        text: "Documentation",
        href: "https://vuetifyjs.com"
      },
      {
        text: "Chat",
        href: "https://community.vuetifyjs.com"
      },
      {
        text: "Made with Vuetify",
        href: "https://madewithvuejs.com/vuetify"
      },
      {
        text: "Twitter",
        href: "https://twitter.com/vuetifyjs"
      },
      {
        text: "Articles",
        href: "https://medium.com/vuetify"
      }
    ],
    whatsNext: [
      {
        text: "Explore components",
        href: "https://vuetifyjs.com/components/api-explorer"
      },
      {
        text: "Select a layout",
        href: "https://vuetifyjs.com/getting-started/pre-made-layouts"
      },
      {
        text: "Frequently Asked Questions",
        href: "https://vuetifyjs.com/getting-started/frequently-asked-questions"
      }
    ]
  })
});
</script>
