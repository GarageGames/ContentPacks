singleton TSShapeConstructor(Soldier_Kralmok_FallDAE)
{
   baseShape = "./Soldier_Kralmok_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "940", "969", true, true);
}
