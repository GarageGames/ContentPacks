singleton TSShapeConstructor(PlayerAnim_Mamba_Crouch_ForwardDAE)
{
   baseShape = "./PlayerAnim_Mamba_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "400", "429");
}
