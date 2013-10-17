   // BEGIN: Shotgun Sequences
   // Extracted from Disposition
   %this.addSequence("./FP_Disposition.DAE run", "Shotgun_run");
   %this.addSequence("./FP_Disposition.DAE sprint", "Shotgun_sprint");
   %this.addSequence("./FP_Disposition.DAE idle", "Shotgun_idle");
   %this.addSequence("./FP_Disposition.DAE idle_fidget1", "Shotgun_idle_fidget1");
   %this.addSequence("./FP_Disposition.DAE fire", "Shotgun_fire");
   %this.addSequence("./FP_Disposition.DAE fire_cocking", "Shotgun_fire_cocking");
   %this.addSequence("./FP_Disposition.DAE reload", "Shotgun_reload");
   %this.addSequence("./FP_Disposition.DAE fire_alt", "Shotgun_fire_alt");
   %this.addSequence("./FP_Disposition.DAE switch_out", "Shotgun_switch_out");
   %this.addSequence("./FP_Disposition.DAE switch_in", "Shotgun_switch_in");
   
   %this.setSequenceCyclic("Shotgun_idle_fidget1", "0");
   %this.setSequenceCyclic("Shotgun_fire", "0");
   %this.setSequenceCyclic("Shotgun_fire_cocking", "0");
   %this.setSequenceCyclic("Shotgun_reload", "0");
   %this.setSequenceCyclic("Shotgun_fire_alt", "0");
   %this.setSequenceCyclic("Shotgun_switch_out", "0");
   %this.setSequenceCyclic("Shotgun_switch_in", "0");
   // END: Shotgun Sequences
   echo(" -- Disposition FP Animations Loaded");