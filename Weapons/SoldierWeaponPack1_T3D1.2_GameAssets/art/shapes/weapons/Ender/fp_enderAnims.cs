   // BEGIN: Ender Sequences
   %this.addSequence("./FP_Ender.DAE run", "Ender_run");
   %this.addSequence("./FP_Ender.DAE run2sprint", "Ender_run2sprint");
   %this.addSequence("./FP_Ender.DAE sprint", "Ender_sprint");
   %this.addSequence("./FP_Ender.DAE sprint2run", "Ender_sprint2run");
   %this.addSequence("./FP_Ender.DAE idle", "Ender_idle");
   %this.addSequence("./FP_Ender.DAE idle_fidget1", "Ender_idle_fidget1");
   %this.addSequence("./FP_Ender.DAE fire", "Ender_fire");
   %this.addSequence("./FP_Ender.DAE fire_alt", "Ender_fire_alt");
   %this.addSequence("./FP_Ender.DAE reload", "Ender_reload");
   %this.addSequence("./FP_Ender.DAE switch_out", "Ender_switch_out");
   %this.addSequence("./FP_Ender.DAE switch_in", "Ender_switch_in");
   
   %this.setSequenceCyclic("Ender_fire", "0");
   %this.setSequenceCyclic("Ender_fire_alt", "0");
   %this.setSequenceCyclic("Ender_reload", "0");
   %this.setSequenceCyclic("Ender_switch_out", "0");
   %this.setSequenceCyclic("Ender_switch_in", "0");
   %this.setSequenceCyclic("Ender_run2sprint", "0");
   %this.setSequenceCyclic("Ender_sprint2run", "0");
   // END: Ender Sequences
   
   echo(" -- Ender FP Animations Loaded");