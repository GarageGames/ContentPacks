   // BEGIN: Kralmok Sequences
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE run", "Kralmok_run");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE run2sprint", "Kralmok_run2sprint");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE sprint", "Kralmok_sprint");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE sprint2run", "Kralmok_sprint2run");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE idle", "Kralmok_idle");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE fire", "Kralmok_fire");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE reload", "Kralmok_reload");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE switch_out", "Kralmok_switch_out");
   %this.addSequence("art/shapes/weapons/Kralmok/FP_Kralmok.DAE switch_in", "Kralmok_switch_in");
   
   %this.setSequenceCyclic("Kralmok_fire", "0");
   %this.setSequenceCyclic("Kralmok_reload", "0");
   %this.setSequenceCyclic("Kralmok_switch_out", "0");
   %this.setSequenceCyclic("Kralmok_switch_in", "0");
   %this.setSequenceCyclic("Kralmok_run2sprint", "0");
   %this.setSequenceCyclic("Kralmok_sprint2run", "0");
   // END: Kralmok Sequences
   
   echo(" -- Kralmok FP Animations Loaded");