singleton TSShapeConstructor(Soldier_Kraad_JumpDAE)
{
   baseShape = "./Soldier_Kraad_Jump.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "1000", "1010", true, true);
}
