   // BEGIN: Kral Sequences
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE run", "Kral_run");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE run2sprint", "Kral_run2sprint");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE sprint", "Kral_sprint");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE sprint2run", "Kral_sprint2run");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE idle", "Kral_idle");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE fire", "Kral_fire");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE reload", "Kral_reload");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE switch_out", "Kral_switch_out");
   %this.addSequence("art/shapes/weapons/Kral/FP_Kral.DAE switch_in", "Kral_switch_in");
   
   %this.setSequenceCyclic("Kral_fire", "0");
   %this.setSequenceCyclic("Kral_reload", "0");
   %this.setSequenceCyclic("Kral_switch_out", "0");
   %this.setSequenceCyclic("Kral_switch_in", "0");
   %this.setSequenceCyclic("Kral_run2sprint", "0");
   %this.setSequenceCyclic("Kral_sprint2run", "0");
   // END: Kral Sequences
   
   echo(" -- Kral FP Animations Loaded");