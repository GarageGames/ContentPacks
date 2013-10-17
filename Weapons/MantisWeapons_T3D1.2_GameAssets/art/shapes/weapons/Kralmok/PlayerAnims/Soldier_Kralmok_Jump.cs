singleton TSShapeConstructor(Soldier_Kralmok_JumpDAE)
{
   baseShape = "./Soldier_Kralmok_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "900", "910", true, true);
}
