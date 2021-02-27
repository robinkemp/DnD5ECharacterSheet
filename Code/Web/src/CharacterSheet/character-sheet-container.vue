<template>
    <v-container>
    <v-row class="text-center">
      <v-col class="mb-4">
        <h1 class="display-2 font-weight-bold mb-3">Character Sheet</h1>
      </v-col>
    </v-row>
    <v-row>
        <v-btn :ripple="false" @click="NewCharacterSheetClick">New Character Sheet</v-btn>
    </v-row>
    <v-row v-if="newCharacterSheet">
      <character-basic-profile/>
    </v-row>
    </v-container>
</template>
<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import CharacterBasicProfile from "./character-basic-profile.vue";

@Component({ components: { } })
export default class CharacterSheet extends Vue {
    newCharacterSheet = false;
    basicProfile = new CharacterBasicProfile;

NewCharacterSheetClick(){
    this.newCharacterSheet = true;
    console.log("Create Character Sheet launched.");
  }
}
</script>
<style lang="scss">

</style>