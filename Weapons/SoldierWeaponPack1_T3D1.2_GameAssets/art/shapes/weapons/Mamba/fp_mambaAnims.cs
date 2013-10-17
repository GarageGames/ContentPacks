   // BEGIN: Mamba Sequences
   %this.addSequence("./FP_Mamba.DAE run", "Mamba_run");
   %this.addSequence("./FP_Mamba.DAE run2sprint", "Mamba_run2sprint");
   %this.addSequence("./FP_Mamba.DAE sprint", "Mamba_sprint");
   %this.addSequence("./FP_Mamba.DAE sprint2run", "Mamba_sprint2run");
   %this.addSequence("./FP_Mamba.DAE idle", "Mamba_idle");
   %this.addSequence("./FP_Mamba.DAE idle_fidget1", "Mamba_idle_fidget1");
   %this.addSequence("./FP_Mamba.DAE fire", "Mamba_fire");
   %this.addSequence("./FP_Mamba.DAE fire_alt", "Mamba_fire_alt");
   %this.addSequence("./FP_Mamba.DAE reload", "Mamba_reload");
   %this.addSequence("./FP_Mamba.DAE switch_out", "Mamba_switch_out");
   %this.addSequence("./FP_Mamba.DAE switch_in", "Mamba_switch_in");
   
   %this.setSequenceCyclic("Mamba_fire", "0");
   %this.setSequenceCyclic("Mamba_fire_alt", "0");
   %this.setSequenceCyclic("Mamba_reload", "0");
   %this.setSequenceCyclic("Mamba_switch_out", "0");
   %this.setSequenceCyclic("Mamba_switch_in", "0");
   %this.setSequenceCyclic("Mamba_run2sprint", "0");
   %this.setSequenceCyclic("Mamba_sprint2run", "0");
   // END: Mamba Sequences
   
   echo(" -- Mamba FP Animations Loaded");